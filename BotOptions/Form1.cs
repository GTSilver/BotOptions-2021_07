using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace BotOptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            Symbol_CB.SelectedIndex = 0;
        }

        public class Setup
        {
            public string symbol;
            public double startLot;
            public double lotCoefficient;
            public double takeprofit;
            public int dealSize;
            public int accuracy;
            public int spred;
            public int leverage;
            public int pipstep1;
            public int orders1;
            public double pipstepCoefficient1;
            public int pipstep2;
            public int orders2;
            public double pipstepCoefficient2;
            public int pipstep3;
            public int orders3;
            public double pipstepCoefficient3;
            public int pipstep4;
            public int orders4;
            public double pipstepCoefficient4;
            public double balance;
            public double quotationMain;
            public double quotationSupport;

            public void SaveSetup(StreamWriter streamWriter)
            {
                streamWriter.WriteLine(symbol);
                streamWriter.WriteLine(startLot);
                streamWriter.WriteLine(lotCoefficient);
                streamWriter.WriteLine(takeprofit);
                streamWriter.WriteLine(dealSize);
                streamWriter.WriteLine(accuracy);
                streamWriter.WriteLine(spred);
                streamWriter.WriteLine(leverage);
                streamWriter.WriteLine(pipstep1);
                streamWriter.WriteLine(orders1);
                streamWriter.WriteLine(pipstepCoefficient1);
                streamWriter.WriteLine(pipstep2);
                streamWriter.WriteLine(orders2);
                streamWriter.WriteLine(pipstepCoefficient2);
                streamWriter.WriteLine(pipstep3);
                streamWriter.WriteLine(orders3);
                streamWriter.WriteLine(pipstepCoefficient3);
                streamWriter.WriteLine(pipstep4);
                streamWriter.WriteLine(orders4);
                streamWriter.WriteLine(pipstepCoefficient4);
                streamWriter.WriteLine(balance);
                streamWriter.WriteLine(quotationMain);
                streamWriter.WriteLine(quotationSupport);

                streamWriter.Close();
            }

            public void LoadSetup(StreamReader streamReader)
            {
                symbol = streamReader.ReadLine();
                startLot = streamReader.ReadLine().ToDouble();
                lotCoefficient = streamReader.ReadLine().ToDouble();
                takeprofit = streamReader.ReadLine().ToDouble();
                dealSize = streamReader.ReadLine().ToInt();
                accuracy = streamReader.ReadLine().ToInt();
                spred = streamReader.ReadLine().ToInt();
                leverage = streamReader.ReadLine().ToInt();
                pipstep1 = streamReader.ReadLine().ToInt();
                orders1 = streamReader.ReadLine().ToInt();
                pipstepCoefficient1 = streamReader.ReadLine().ToDouble();
                pipstep2 = streamReader.ReadLine().ToInt();
                orders2 = streamReader.ReadLine().ToInt();
                pipstepCoefficient2 = streamReader.ReadLine().ToDouble();
                pipstep3 = streamReader.ReadLine().ToInt();
                orders3 = streamReader.ReadLine().ToInt();
                pipstepCoefficient3 = streamReader.ReadLine().ToDouble();
                pipstep4 = streamReader.ReadLine().ToInt();
                orders4 = streamReader.ReadLine().ToInt();
                pipstepCoefficient4 = streamReader.ReadLine().ToDouble();
                balance = streamReader.ReadLine().ToDouble();
                quotationMain = streamReader.ReadLine().ToDouble();
                quotationSupport = streamReader.ReadLine().ToDouble();

                streamReader.Close();
            }
        }

        public class Strategy
        {
            public List<Order> orders = new List<Order>();
            public int startPipstep;
            public double pipstepCoefficient;

            public double GetQuotationVoid(Setup setup)
            {
                double numerator = 0;
                double denominator = 0;

                foreach (var order in orders)
                {
                    numerator += order.GetQuotationTakeprofit(setup) * order.lot;
                    denominator += order.lot;
                }

                return Math.Round(numerator / denominator, setup.accuracy);
            }

            public int GetItemSize()
            {
                double sumCoefficient = 0;
                for (var i = 0; i < orders.Count - 1; i++)
                    sumCoefficient += Math.Pow(pipstepCoefficient, i);

                return (int)Math.Ceiling(sumCoefficient * startPipstep);
            }

            public double GetQuotationSize(Setup setup)
            {
                return Math.Round(GetItemSize() / Math.Pow(10, setup.accuracy), setup.accuracy);
            }

            public void FillStrategy(double quotationStartValue, int orderCount, bool buyType, Setup setup)
            {
                for (var i = 0; i < orderCount; i++)
                {
                    if (orders.Count <= 0)
                        orders.Add(new Order()
                        {
                            buyType = buyType,
                            lot = Math.Round(Math.Ceiling(setup.startLot * 100) / 100, 2)
                        });
                    else
                    {
                        orders.Add(new Order()
                        {
                            buyType = buyType,
                            lot = Math.Round(Math.Ceiling(orders[i - 1].lot * setup.lotCoefficient * 100) / 100, 2)
                        });
                    }
                    if (orders.Count <= 1)
                        orders[i].quotationOpen = quotationStartValue;
                    else if (buyType)
                        orders[i].quotationOpen = Math.Round(orders[i - 1].quotationOpen - startPipstep * Math.Pow(pipstepCoefficient, i - 1) / Math.Pow(10, setup.accuracy), setup.accuracy);
                    else
                        orders[i].quotationOpen = Math.Round(orders[i - 1].quotationOpen + startPipstep * Math.Pow(pipstepCoefficient, i - 1) / Math.Pow(10, setup.accuracy), setup.accuracy);
                }
            }

            public double GetMargin(Setup setup)
            {
                var sumLot = 0d;

                foreach (var order in orders)
                    sumLot += order.lot;

                return sumLot * setup.dealSize / setup.leverage * setup.quotationMain;
            }

            public double GetMargin(int endOrder, Setup setup)
            {
                var sumLot = 0d;

                for (var i = 0; i < endOrder; i++)
                    sumLot += orders[i].lot;

                return sumLot * setup.dealSize / setup.leverage * setup.quotationMain;
            }

            public double GetProfit(double quotation, Setup setup)
            {
                var sum = 0d;

                foreach (var order in orders)
                    sum += order.GetProfit(quotation, setup);

                return sum;
            }

            public double GetProfit(double quotation, int endOrder, Setup setup)
            {
                var sum = 0d;

                for (var i = 0; i < endOrder; i++)
                    sum += orders[i].GetProfit(quotation, setup);

                return sum;
            }
        }

        public class Order
        {
            public bool buyType;
            public double lot;
            public double quotationOpen;

            public double GetQuotationTakeprofit(Setup setup)
            {
                if (buyType)
                    return quotationOpen + setup.takeprofit / Math.Pow(10, setup.accuracy);
                else
                    return quotationOpen - setup.takeprofit / Math.Pow(10, setup.accuracy);
            }

            public double GetProfit(double quotation, Setup setup)
            {
                if (buyType)
                    return lot * setup.dealSize * (quotation - quotationOpen) * setup.quotationSupport;
                else
                    return lot * setup.dealSize * (quotationOpen - quotation) * setup.quotationSupport;
            }
        }

        public class Step
        {
            public double quotation = 0;
            public double profitMain = 0;
            public double profitSupport = 0;
            public double profitSum = 0;
            public double marginMain = 0;
            public double marginLevel = 0;
        }

        public class Track
        {
            public Dictionary<double, bool> checpoints = new Dictionary<double, bool>();

            public bool GetCrossed()
            {
                foreach (var checpoint in checpoints)
                    if (checpoint.Value == false)
                        return false;

                return true;
            }
        }

        public bool CheckSetup()
        {
            try { StartLot_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nНачальный лот заполнен не корректно."); return false; }
            try { LotCoefficient_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nМультификатор лота заполнен не корректно."); return false; }
            try { TakeProfit_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nТейкпрофит заполнен не корректно."); return false; }
            try { DealSize_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nОбъём сделки заполнен не корректно."); return false; }
            try { Accuracy_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nТочность заполнена не корректно."); return false; }
            try { Spred_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nСпред заполнен не корректно."); return false; }
            try { Leverage_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nКрежитное плечё заполнено не корректно."); return false; }
            try { Pipstep1_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nНачальный пипстеп стратегии 1 заполнен не корректно."); return false; }
            try { Orders1_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nКоличество ордеров стратегии 1 заполнено не корректно."); return false; }
            try { PipstepCoefficient1_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nМультификатор пипстепа стратегии 1 заполнен не корректно."); return false; }
            try { Pipstep2_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nНачальный пипстеп стратегии 2 заполнен не корректно."); return false; }
            try { Orders2_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nКоличество ордеров стратегии 2 заполнено не корректно."); return false; }
            try { PipstepCoefficient2_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nМультификатор пипстепа стратегии 2 заполнен не корректно."); return false; }
            try { Pipstep3_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nНачальный пипстеп стратегии 3 заполнен не корректно."); return false; }
            try { Orders3_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nКоличество ордеров стратегии 3 заполнено не корректно."); return false; }
            try { PipstepCoefficient3_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nМультификатор пипстепа стратегии 3 заполнен не корректно."); return false; }
            try { Pipstep4_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nНачальный пипстеп стратегии 4 заполнен не корректно."); return false; }
            try { Orders4_TB.Text.ToInt(); } catch { MessageBox.Show("Ошибка!\nКоличество ордеров стратегии 4 заполнено не корректно."); return false; }
            try { PipstepCoefficient4_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nМультификатор пипстепа стратегии 4 заполнен не корректно."); return false; }
            try { Balance_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nВелечина баланса заполнена не корректно"); return false; }
            try { QuotationMain_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nКотировка базовой (прямой) валюты заполнена не корректно."); return false; }
            try { QuotationSupport_TB.Text.ToDouble(); } catch { MessageBox.Show("Ошибка!\nКотировка котируемой (обратной) валюты заполнена не корректно."); return false; }

return true;
        }

        public void SetSetup(Setup setup)
        {
            Symbol_CB.Text = setup.symbol;
            StartLot_TB.Text = setup.startLot.ToString();
            LotCoefficient_TB.Text = setup.lotCoefficient.ToString();
            TakeProfit_TB.Text = setup.takeprofit.ToString();
            DealSize_TB.Text = setup.dealSize.ToString();
            Accuracy_TB.Text = setup.accuracy.ToString();
            Spred_TB.Text = setup.spred.ToString();
            Leverage_TB.Text = setup.leverage.ToString();
            Pipstep1_TB.Text = setup.pipstep1.ToString();
            Orders1_TB.Text = setup.orders1.ToString();
            PipstepCoefficient1_TB.Text = setup.pipstepCoefficient1.ToString();
            Pipstep2_TB.Text = setup.pipstep2.ToString();
            Orders2_TB.Text = setup.orders2.ToString();
            PipstepCoefficient2_TB.Text = setup.pipstepCoefficient2.ToString();
            Pipstep3_TB.Text = setup.pipstep3.ToString();
            Orders3_TB.Text = setup.orders3.ToString();
            PipstepCoefficient3_TB.Text = setup.pipstepCoefficient3.ToString();
            Pipstep4_TB.Text = setup.pipstep4.ToString();
            Orders4_TB.Text = setup.orders4.ToString();
            PipstepCoefficient4_TB.Text = setup.pipstepCoefficient4.ToString();
            Balance_TB.Text = setup.balance.ToString();
            QuotationMain_TB.Text = setup.quotationMain.ToString();
            QuotationSupport_TB.Text = setup.quotationSupport.ToString();
        }

        public void GetSetup(Setup setup)
        {
            setup.symbol = Symbol_CB.Text;
            setup.startLot = StartLot_TB.Text.ToDouble();
            setup.lotCoefficient = LotCoefficient_TB.Text.ToDouble();
            setup.takeprofit = TakeProfit_TB.Text.ToDouble();
            setup.dealSize = DealSize_TB.Text.ToInt();
            setup.accuracy = Accuracy_TB.Text.ToInt();
            setup.spred = Spred_TB.Text.ToInt();
            setup.leverage = Leverage_TB.Text.ToInt();
            setup.pipstep1 = Pipstep1_TB.Text.ToInt();
            setup.orders1 = Orders1_TB.Text.ToInt();
            setup.pipstepCoefficient1 = PipstepCoefficient1_TB.Text.ToDouble();
            setup.pipstep2 = Pipstep2_TB.Text.ToInt();
            setup.orders2 = Orders2_TB.Text.ToInt();
            setup.pipstepCoefficient2 = PipstepCoefficient2_TB.Text.ToDouble();
            setup.pipstep3 = Pipstep3_TB.Text.ToInt();
            setup.orders3 = Orders3_TB.Text.ToInt();
            setup.pipstepCoefficient3 = PipstepCoefficient3_TB.Text.ToDouble();
            setup.pipstep4 = Pipstep4_TB.Text.ToInt();
            setup.orders4 = Orders4_TB.Text.ToInt();
            setup.pipstepCoefficient4 = PipstepCoefficient4_TB.Text.ToDouble();
            setup.balance = Balance_TB.Text.ToDouble();
            setup.quotationMain = QuotationMain_TB.Text.ToDouble();
            setup.quotationSupport = QuotationSupport_TB.Text.ToDouble();
        }

        public List<Step> CalculateVariations(double startQuotation, double endQuotation, Track track, List<Strategy> strategies, Setup setup)
        {
            var result = new List<Step>();
            bool revers = false;
            double step = startQuotation;
            int mainOrders = 0;
            int mainOrdersCount = 0;
            Strategy currentStrategy = strategies[0];
            List<Order> supportOrders = new List<Order>();
            while (true)
            {
                var newStep = new Step();

                //Подсчёт закрытых вспомогательных ордеров
                for (var i = 0; i < supportOrders.Count - 1; i++)
                    newStep.profitSupport += supportOrders[i].GetProfit(supportOrders[i].GetQuotationTakeprofit(setup), setup);

                //Учёт последнего открытого вспомогательного ордера
                if (supportOrders.Count > 0)
                    newStep.profitSupport += supportOrders[supportOrders.Count - 1].GetProfit(step, setup);

                //Подсчёт главных ордеров
                for (var i = 0; i < strategies.Count; i++)
                    if (mainOrdersCount >= strategies[i].orders.Count)
                        foreach (var order in strategies[i].orders)
                        {
                            newStep.marginMain += order.lot * setup.dealSize / setup.leverage * setup.quotationMain;
                            newStep.profitMain += order.GetProfit(step, setup);
                            mainOrdersCount--;
                        }
                    else
                        for (var j = 0; j < mainOrdersCount + j; j++)
                        {
                            newStep.marginMain += strategies[i].orders[j].lot * setup.dealSize / setup.leverage * setup.quotationMain;
                            newStep.profitMain += strategies[i].orders[j].GetProfit(step, setup);
                            mainOrdersCount--;
                        }

                newStep.profitSum = newStep.profitMain + newStep.profitSupport;
                newStep.marginLevel = (setup.balance + newStep.profitSum) / newStep.marginMain * 100;

                newStep.marginLevel = Math.Round(newStep.marginLevel, 2);
                newStep.marginMain = Math.Round(newStep.marginMain, 2);
                newStep.profitMain = Math.Round(newStep.profitMain, 2);
                newStep.profitSum = Math.Round(newStep.profitSum, 2);
                newStep.profitSupport = Math.Round(newStep.profitSupport, 2);
                newStep.quotation = Math.Round(step, setup.accuracy);


                result.Add(newStep);

                //Выход в конечной точки после всех чекпоинтов
                if (step == endQuotation && track.GetCrossed()) break;

                //Реверс в точках чекпоинта и смена стратегии
                foreach (var checkpoint in track.checpoints)
                    if (checkpoint.Key == step && checkpoint.Value == false)
                    {
                        track.checpoints[step] = true;

                        for (var i = 0; i < strategies.Count - 1; i++)
                            if (strategies[i] == currentStrategy && i < strategies.Count - 1)
                                currentStrategy = strategies[i + 1];

                        revers = !revers;
                        break;
                    }
                    else if (checkpoint.Value == false) break;

                //Открытие первого вспомогательного ордера
                if (revers == currentStrategy.orders[0].buyType && (step == currentStrategy.orders[0].quotationOpen + currentStrategy.startPipstep / Math.Pow(10, setup.accuracy)))
                    supportOrders.Add(new Order { quotationOpen = Math.Round(step + setup.spred / Math.Pow(10, setup.accuracy), setup.accuracy), buyType = true, lot = setup.startLot });
                else if (!revers == currentStrategy.orders[0].buyType && (step == Math.Round(currentStrategy.orders[0].quotationOpen - currentStrategy.startPipstep / Math.Pow(10, setup.accuracy), setup.accuracy)))
                    supportOrders.Add(new Order { quotationOpen = Math.Round(step - setup.spred / Math.Pow(10, setup.accuracy), setup.accuracy), buyType = false, lot = setup.startLot });
                else
                //Открытие последующих вспомогательных ордеров
                if (supportOrders.Count > 0)
                    if (supportOrders[supportOrders.Count - 1].buyType)
                    {
                        if (step >= supportOrders[supportOrders.Count - 1].GetQuotationTakeprofit(setup))
                            supportOrders.Add(new Order { quotationOpen = step, buyType = true, lot = setup.startLot });
                    }
                    else
                    {
                        if (step <= supportOrders[supportOrders.Count - 1].GetQuotationTakeprofit(setup))
                            supportOrders.Add(new Order { quotationOpen = step, buyType = false, lot = setup.startLot });
                    }

                //Учёт открытия главных ордеров
                foreach (var order in currentStrategy.orders)
                    if (order.quotationOpen == step && order.buyType == !revers)
                    {
                        mainOrders++;
                        break;
                    }

                mainOrdersCount = mainOrders;
                //Движение котировок
                if (revers) step += Math.Round(Math.Pow(10, -setup.accuracy), setup.accuracy);
                else step -= Math.Round(Math.Pow(10, -setup.accuracy), setup.accuracy);

                step = Math.Round(step, setup.accuracy);
            }

            return result;
        }

        public void FillData(string name, List<Step> steps)
        {
            var profit = steps[0];
            var margin = steps[0];
            var marginLevel = steps[0];

            foreach(var step in steps)
            {
                if (profit.profitSum > step.profitSum) profit = step;
                if (margin.marginMain < step.marginMain) margin = step;
                if (marginLevel.marginLevel > step.marginLevel) marginLevel = step;
            }

            Result_DGV.Rows.Add(name + " (мин. проф.)", profit.quotation, profit.profitMain, profit.profitSupport, profit.profitSum, profit.marginMain, profit.marginLevel);
            Result_DGV.Rows.Add(name + " (макс. маржа)", margin.quotation, margin.profitMain, margin.profitSupport, margin.profitSum, margin.marginMain, margin.marginLevel);
            Result_DGV.Rows.Add(name + " (мин. ур. маржи)", marginLevel.quotation, marginLevel.profitMain, marginLevel.profitSupport, marginLevel.profitSum, marginLevel.marginMain, marginLevel.marginLevel);
        }

        public void FillData(string name, Step step, Setup setup)
        {
            Result_DGV.Rows.Add(name, "-", step.profitMain, step.profitSupport, step.profitSum, step.marginMain, Math.Round((setup.balance + step.profitSum) / step.marginMain * 100), 0);
        }

        public void FillData(Step step, Setup setup)
        {
            Result_DGV.Rows.Add(setup.symbol, "-", "-", step.profitSupport, "-", step.marginMain, "-");
        }

        public List<List<Step>> CalculateSymbol(Setup setup)
        {
            Result_DGV.Rows.Clear();

            //Одна стратегия
            var strategy11 = new Strategy()
            {
                startPipstep = setup.pipstep1,
                pipstepCoefficient = setup.pipstepCoefficient1
            };
            strategy11.FillStrategy
            (
                0,
                setup.orders1,
                true,
                setup
            );

            var track1 = new Track();
            track1.checpoints.Add(Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen, setup.accuracy), false);
            var steps1 = CalculateVariations
                (
                    strategy11.orders[0].quotationOpen,
                    Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen + Math.Pow(10, -setup.accuracy), setup.accuracy),
                    track1,
                    new List<Strategy>() { strategy11 },
                    setup
                );
            steps1.RemoveAt(0);

            //Две стратегии
            var strategy22 = new Strategy()
            {
                startPipstep = setup.pipstep2,
                pipstepCoefficient = setup.pipstepCoefficient2
            };
            strategy22.FillStrategy
            (
                strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy22.GetQuotationSize(setup),
                setup.orders2,
                false,
                setup
            );

            var track2 = new Track();
            track2.checpoints.Add(Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy22.GetQuotationSize(setup), setup.accuracy), false);
            var steps2 = CalculateVariations
                (
                    strategy11.orders[0].quotationOpen,
                    Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen, setup.accuracy),
                    track2,
                    new List<Strategy>() { strategy11, strategy22 },
                    setup
                );
            steps2.RemoveAt(0);

            //Три стратегии
            var strategy33 = new Strategy()
            {
                startPipstep = setup.pipstep3,
                pipstepCoefficient = setup.pipstepCoefficient3
            };
            strategy33.FillStrategy
            (
                strategy11.orders[strategy11.orders.Count - 1].quotationOpen,
                setup.orders3,
                true,
                setup
            );

            var strategy32 = new Strategy()
            {
                startPipstep = setup.pipstep2,
                pipstepCoefficient = setup.pipstepCoefficient2
            };
            strategy32.FillStrategy
            (
                strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy22.GetQuotationSize(setup) - strategy33.GetQuotationSize(setup),
                setup.orders2,
                false,
                setup
            );

            var track3 = new Track();
            track3.checpoints.Add(Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy22.GetQuotationSize(setup) - strategy33.GetQuotationSize(setup), setup.accuracy), false);
            track3.checpoints.Add(Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen, setup.accuracy), false);
            var steps3 = CalculateVariations
                (
                    strategy11.orders[0].quotationOpen,
                    Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy33.GetQuotationSize(setup), setup.accuracy),
                    track3,
                    new List<Strategy>() { strategy11, strategy32, strategy33 },
                    setup
                );
            steps3.RemoveAt(0);

            //Четыре стратегии
            var strategy440 = new Strategy()
            {
                startPipstep = setup.pipstep4,
                pipstepCoefficient = setup.pipstepCoefficient4
            };  //Темпоральная стратегия, необходимая для расчёта 42
            strategy440.FillStrategy
            (
                0,
                setup.orders4,
                false,
                setup
            );

            var strategy42 = new Strategy()
            {
                startPipstep = setup.pipstep2,
                pipstepCoefficient = setup.pipstepCoefficient2
            };
            strategy42.FillStrategy
            (
                strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy22.GetQuotationSize(setup) - strategy33.GetQuotationSize(setup) - strategy440.GetQuotationSize(setup),
                setup.orders2,
                false,
                setup
            );

            var strategy44 = new Strategy()
            {
                startPipstep = setup.pipstep4,
                pipstepCoefficient = setup.pipstepCoefficient4
            };
            strategy44.FillStrategy
            (
                strategy42.orders[strategy42.orders.Count - 1].quotationOpen,
                setup.orders4,
                false,
                setup
            );

            var track4 = new Track();
            track4.checpoints.Add(Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy22.GetQuotationSize(setup) - strategy33.GetQuotationSize(setup) - strategy440.GetQuotationSize(setup), setup.accuracy), false);
            track4.checpoints.Add(Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen, setup.accuracy), false);
            track4.checpoints.Add(Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy33.GetQuotationSize(setup) - strategy440.GetQuotationSize(setup), setup.accuracy), false);
            var steps4 = CalculateVariations
                (
                    strategy11.orders[0].quotationOpen,
                    Math.Round(strategy11.orders[strategy11.orders.Count - 1].quotationOpen - strategy33.GetQuotationSize(setup), setup.accuracy),
                    track4,
                    new List<Strategy>() { strategy11, strategy42, strategy33, strategy44 },
                    setup
                );
            steps4.RemoveAt(0);

            var result = new List<List<Step>>();

            result.Add(steps1);
            result.Add(steps2);
            result.Add(steps3);
            result.Add(steps4);

            return result;
        }

        private void Calculate_B_Click(object sender, EventArgs e)
        {
            if (!CheckSetup()) return;

            var newSetup = new Setup();
            if (Symbol_CB.SelectedIndex < 0)
                GetSetup(newSetup);
            else
            {
                var fileSteam = new StreamReader(Directory.GetCurrentDirectory() + "\\" + Symbol_CB.Text + ".symbol");
                newSetup.LoadSetup(fileSteam);
                SetSetup(newSetup);
            }

            var result = CalculateSymbol(newSetup);

            FillData("1 стр.", result[0]);
            FillData("2 стр.", result[1]);
            FillData("3 стр.", result[2]);
            FillData("4 стр.", result[3]);
        }

        private void FullCalculate_B_Click(object sender, EventArgs e)
        {
            var resultData = new Dictionary<string, List<List<Step>>>();
            var newSetup = new Setup();

            if (Symbol_CB.SelectedIndex < 0)
            {
                GetSetup(newSetup);
                CalculateSymbol(newSetup);
            }
            else
                foreach (var item in Symbol_CB.Items)
                {
                    var fileSteam = new StreamReader(Directory.GetCurrentDirectory() + "\\" + (string)item + ".symbol");
                    newSetup.LoadSetup(fileSteam);
                    SetSetup(newSetup);
                    resultData.Add(newSetup.symbol, CalculateSymbol(newSetup));
                }

            var resultStategy1 = new Step();
            var resultStategy2 = new Step();
            var resultStategy3 = new Step();
            var resultStategy4 = new Step();
            foreach (var data in resultData)
            {
                var fileSteam = new StreamReader(Directory.GetCurrentDirectory() + "\\" + data.Key + ".symbol");
                newSetup.LoadSetup(fileSteam);

                Step profitSum;
                Step margin;
                Step supportMax;
                Step mainMin;

                var strategy1 = data.Value[0];
                profitSum = new Step();
                margin = new Step();
                supportMax = new Step();
                mainMin = new Step();
                foreach (var step in strategy1)
                {
                    if (profitSum.profitSum > step.profitSum) profitSum = step;
                    if (margin.marginMain < step.marginMain) margin = step;
                    if (mainMin.profitMain > step.profitMain) mainMin = step;
                    if (supportMax.profitSupport < step.profitSupport) supportMax = step;
                }
                resultStategy1.profitSum += profitSum.profitSum;
                resultStategy1.marginMain += margin.marginMain;
                resultStategy1.profitMain += mainMin.profitMain;
                resultStategy1.profitSupport += supportMax.profitSupport;

                var strategy2 = data.Value[1];
                profitSum = new Step();
                margin = new Step();
                supportMax = new Step();
                mainMin = new Step();
                foreach (var step in strategy2)
                {
                    if (profitSum.profitSum > step.profitSum) profitSum = step;
                    if (margin.marginMain < step.marginMain) margin = step;
                    if (mainMin.profitMain > step.profitMain) mainMin = step;
                    if (supportMax.profitSupport < step.profitSupport) supportMax = step;
                }
                resultStategy2.profitSum += profitSum.profitSum;
                resultStategy2.marginMain += margin.marginMain;
                resultStategy2.profitMain += mainMin.profitMain;
                resultStategy2.profitSupport += supportMax.profitSupport;

                var strategy3 = data.Value[2];
                profitSum = new Step();
                margin = new Step();
                supportMax = new Step();
                mainMin = new Step();
                foreach (var step in strategy3)
                {
                    if (profitSum.profitSum > step.profitSum) profitSum = step;
                    if (margin.marginMain < step.marginMain) margin = step;
                    if (mainMin.profitMain > step.profitMain) mainMin = step;
                    if (supportMax.profitSupport < step.profitSupport) supportMax = step;
                }
                resultStategy3.profitSum += profitSum.profitSum;
                resultStategy3.marginMain += margin.marginMain;
                resultStategy3.profitMain += mainMin.profitMain;
                resultStategy3.profitSupport += supportMax.profitSupport;

                var strategy4 = data.Value[3];
                profitSum = new Step();
                margin = new Step();
                supportMax = new Step();
                mainMin = new Step();
                foreach (var step in strategy4)
                {
                    if (profitSum.profitSum > step.profitSum) profitSum = step;
                    if (margin.marginMain < step.marginMain) margin = step;
                    if (mainMin.profitMain > step.profitMain) mainMin = step;
                    if (supportMax.profitSupport < step.profitSupport) supportMax = step;
                }
                resultStategy4.profitSum += profitSum.profitSum;
                resultStategy4.marginMain += margin.marginMain;
                resultStategy4.profitMain += mainMin.profitMain;
                resultStategy4.profitSupport += supportMax.profitSupport;

                FillData(data.Value[0][newSetup.pipstep1 + newSetup.spred + (int)Math.Ceiling(newSetup.takeprofit)], newSetup);
            }

            FillData("Равёрнуто 1 стратегия", resultStategy1, newSetup);
            FillData("Равёрнуто 2 стратегии", resultStategy2, newSetup);
            FillData("Равёрнуто 3 стратегии", resultStategy3, newSetup);
            FillData("Равёрнуто 4 стратегии", resultStategy4, newSetup);
        }

        private void SaveSymbol_B_Click(object sender, EventArgs e)
        {
            var itemExist = false;

            foreach (var item in Symbol_CB.Items)
                if ((string)item == Symbol_CB.Text)
                    itemExist = true;

            if (itemExist)
                Symbol_CB.SelectedIndex = Symbol_CB.FindString(Symbol_CB.Text);
            else
                Symbol_CB.Items.Add(Symbol_CB.Text);

            var newSetup = new Setup();
            GetSetup(newSetup);

            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            var fileExist = false;
            var files = directory.GetFiles();

            foreach (var file in files)
                if (file.Name == newSetup.symbol + ".symbol")
                    fileExist = true;

            if (!fileExist)
                File.Create(Directory.GetCurrentDirectory() + "\\" + newSetup.symbol + ".symbol").Close();

            var fileSteam = new StreamWriter(Directory.GetCurrentDirectory() + "\\" + newSetup.symbol + ".symbol");

            newSetup.SaveSetup(fileSteam);

            MessageBox.Show("Символ \"" + Symbol_CB.Text + "\" был успешно сохранён.");
        }

        public void LoadSettings()
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            var files = directory.GetFiles();
            var fileList = new List<FileInfo>();

            foreach (var file in files)
                if (file.Extension == ".symbol")
                    fileList.Add(file);

            Symbol_CB.Items.Clear();
            foreach (var file in fileList)
                Symbol_CB.Items.Add(file.Name.Split('.')[0]);
        }

        private void Symbol_CB_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Symbol_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileSteam = new StreamReader(Directory.GetCurrentDirectory() + "\\" + Symbol_CB.Text + ".symbol");
            var newSetup = new Setup();
            newSetup.LoadSetup(fileSteam);
            SetSetup(newSetup);
        }

        private void DeleteSymbol_B_Click(object sender, EventArgs e)
        {
            File.Delete(Directory.GetCurrentDirectory() + "\\" + Symbol_CB.Text + ".symbol");
            Symbol_CB.Items.Remove(Symbol_CB.SelectedItem);

            MessageBox.Show("Символ \"" + Symbol_CB.Text + "\" был успешно удалён.");
        }
    }

    public static class StringExtention
    {
        public static int ToInt(this string input)
        {
            return int.Parse(input, CultureInfo.InvariantCulture);
        }

        public static double ToDouble(this string input)
        {
            if (input.Contains("."))
            {
                var temporaryString = input.Split('.');
                input = temporaryString[0] + "," + temporaryString[1];
            }

            return Convert.ToDouble(input);
        }

        public static float ToFloat(this string input)
        {
            return float.Parse(input, CultureInfo.InvariantCulture);
        }
    }
}