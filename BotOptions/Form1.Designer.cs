
namespace BotOptions
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartLot_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LotCoefficient_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TakeProfit_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Accuracy_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DealSize_TB = new System.Windows.Forms.TextBox();
            this.Calculate_B = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Spred_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Pipstep1_TB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Orders1_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PipstepCoefficient1_TB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Orders2_TB = new System.Windows.Forms.TextBox();
            this.Pipstep2_TB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PipstepCoefficient2_TB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Orders3_TB = new System.Windows.Forms.TextBox();
            this.Pipstep3_TB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PipstepCoefficient3_TB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Orders4_TB = new System.Windows.Forms.TextBox();
            this.Pipstep4_TB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.PipstepCoefficient4_TB = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Leverage_TB = new System.Windows.Forms.TextBox();
            this.Result_DGV = new System.Windows.Forms.DataGridView();
            this.Type_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quotation_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainProfit_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupportProfit_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultProfit_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margin_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_TB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Symbol_CB = new System.Windows.Forms.ComboBox();
            this.SaveSymbol_B = new System.Windows.Forms.Button();
            this.FullCalculate_B = new System.Windows.Forms.Button();
            this.DeleteSymbol_B = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.QuotationMain_TB = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.QuotationSupport_TB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLot_TB
            // 
            this.StartLot_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLot_TB.Location = new System.Drawing.Point(15, 25);
            this.StartLot_TB.Name = "StartLot_TB";
            this.StartLot_TB.Size = new System.Drawing.Size(128, 21);
            this.StartLot_TB.TabIndex = 0;
            this.StartLot_TB.Text = "0.15";
            this.StartLot_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальный лот";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мультификатор лота";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LotCoefficient_TB
            // 
            this.LotCoefficient_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LotCoefficient_TB.Location = new System.Drawing.Point(149, 26);
            this.LotCoefficient_TB.Name = "LotCoefficient_TB";
            this.LotCoefficient_TB.Size = new System.Drawing.Size(128, 21);
            this.LotCoefficient_TB.TabIndex = 2;
            this.LotCoefficient_TB.Text = "1.5";
            this.LotCoefficient_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тейкпрофит, п.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TakeProfit_TB
            // 
            this.TakeProfit_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeProfit_TB.Location = new System.Drawing.Point(283, 26);
            this.TakeProfit_TB.Name = "TakeProfit_TB";
            this.TakeProfit_TB.Size = new System.Drawing.Size(128, 21);
            this.TakeProfit_TB.TabIndex = 3;
            this.TakeProfit_TB.Text = "13";
            this.TakeProfit_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Точность котировки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accuracy_TB
            // 
            this.Accuracy_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accuracy_TB.Location = new System.Drawing.Point(417, 66);
            this.Accuracy_TB.Name = "Accuracy_TB";
            this.Accuracy_TB.Size = new System.Drawing.Size(128, 21);
            this.Accuracy_TB.TabIndex = 8;
            this.Accuracy_TB.Text = "4";
            this.Accuracy_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Объём сделки символа";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DealSize_TB
            // 
            this.DealSize_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DealSize_TB.Location = new System.Drawing.Point(417, 26);
            this.DealSize_TB.Name = "DealSize_TB";
            this.DealSize_TB.Size = new System.Drawing.Size(128, 21);
            this.DealSize_TB.TabIndex = 4;
            this.DealSize_TB.Text = "100000";
            this.DealSize_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calculate_B
            // 
            this.Calculate_B.Location = new System.Drawing.Point(417, 107);
            this.Calculate_B.Name = "Calculate_B";
            this.Calculate_B.Size = new System.Drawing.Size(128, 20);
            this.Calculate_B.TabIndex = 13;
            this.Calculate_B.Text = "Расчёт данной пары";
            this.Calculate_B.UseVisualStyleBackColor = true;
            this.Calculate_B.Click += new System.EventHandler(this.Calculate_B_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Велечина спреда, п.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spred_TB
            // 
            this.Spred_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spred_TB.Location = new System.Drawing.Point(283, 66);
            this.Spred_TB.Name = "Spred_TB";
            this.Spred_TB.Size = new System.Drawing.Size(128, 21);
            this.Spred_TB.TabIndex = 7;
            this.Spred_TB.Text = "2";
            this.Spred_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Начальный пипстеп";
            // 
            // Pipstep1_TB
            // 
            this.Pipstep1_TB.Location = new System.Drawing.Point(9, 32);
            this.Pipstep1_TB.Name = "Pipstep1_TB";
            this.Pipstep1_TB.Size = new System.Drawing.Size(113, 20);
            this.Pipstep1_TB.TabIndex = 15;
            this.Pipstep1_TB.Text = "15";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Orders1_TB);
            this.groupBox1.Controls.Add(this.Pipstep1_TB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PipstepCoefficient1_TB);
            this.groupBox1.Location = new System.Drawing.Point(15, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 142);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стратегия 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Кол-во ордеров";
            // 
            // Orders1_TB
            // 
            this.Orders1_TB.Location = new System.Drawing.Point(9, 71);
            this.Orders1_TB.Name = "Orders1_TB";
            this.Orders1_TB.Size = new System.Drawing.Size(113, 20);
            this.Orders1_TB.TabIndex = 16;
            this.Orders1_TB.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Мульт. пипстепа";
            // 
            // PipstepCoefficient1_TB
            // 
            this.PipstepCoefficient1_TB.Location = new System.Drawing.Point(9, 110);
            this.PipstepCoefficient1_TB.Name = "PipstepCoefficient1_TB";
            this.PipstepCoefficient1_TB.Size = new System.Drawing.Size(113, 20);
            this.PipstepCoefficient1_TB.TabIndex = 17;
            this.PipstepCoefficient1_TB.Text = "1.2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Orders2_TB);
            this.groupBox2.Controls.Add(this.Pipstep2_TB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.PipstepCoefficient2_TB);
            this.groupBox2.Location = new System.Drawing.Point(149, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 142);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стратегия 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Кол-во ордеров";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Начальный пипстеп";
            // 
            // Orders2_TB
            // 
            this.Orders2_TB.Location = new System.Drawing.Point(9, 71);
            this.Orders2_TB.Name = "Orders2_TB";
            this.Orders2_TB.Size = new System.Drawing.Size(113, 20);
            this.Orders2_TB.TabIndex = 19;
            this.Orders2_TB.Text = "6";
            // 
            // Pipstep2_TB
            // 
            this.Pipstep2_TB.Location = new System.Drawing.Point(9, 32);
            this.Pipstep2_TB.Name = "Pipstep2_TB";
            this.Pipstep2_TB.Size = new System.Drawing.Size(113, 20);
            this.Pipstep2_TB.TabIndex = 18;
            this.Pipstep2_TB.Text = "20";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Мульт. пипстепа";
            // 
            // PipstepCoefficient2_TB
            // 
            this.PipstepCoefficient2_TB.Location = new System.Drawing.Point(9, 110);
            this.PipstepCoefficient2_TB.Name = "PipstepCoefficient2_TB";
            this.PipstepCoefficient2_TB.Size = new System.Drawing.Size(113, 20);
            this.PipstepCoefficient2_TB.TabIndex = 20;
            this.PipstepCoefficient2_TB.Text = "1.2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Orders3_TB);
            this.groupBox3.Controls.Add(this.Pipstep3_TB);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.PipstepCoefficient3_TB);
            this.groupBox3.Location = new System.Drawing.Point(283, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 142);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Стратегия 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Кол-во ордеров";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Начальный пипстеп";
            // 
            // Orders3_TB
            // 
            this.Orders3_TB.Location = new System.Drawing.Point(9, 71);
            this.Orders3_TB.Name = "Orders3_TB";
            this.Orders3_TB.Size = new System.Drawing.Size(113, 20);
            this.Orders3_TB.TabIndex = 22;
            this.Orders3_TB.Text = "6";
            // 
            // Pipstep3_TB
            // 
            this.Pipstep3_TB.Location = new System.Drawing.Point(9, 32);
            this.Pipstep3_TB.Name = "Pipstep3_TB";
            this.Pipstep3_TB.Size = new System.Drawing.Size(113, 20);
            this.Pipstep3_TB.TabIndex = 21;
            this.Pipstep3_TB.Text = "25";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Мульт. пипстепа";
            // 
            // PipstepCoefficient3_TB
            // 
            this.PipstepCoefficient3_TB.Location = new System.Drawing.Point(9, 110);
            this.PipstepCoefficient3_TB.Name = "PipstepCoefficient3_TB";
            this.PipstepCoefficient3_TB.Size = new System.Drawing.Size(113, 20);
            this.PipstepCoefficient3_TB.TabIndex = 23;
            this.PipstepCoefficient3_TB.Text = "1.2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.Orders4_TB);
            this.groupBox4.Controls.Add(this.Pipstep4_TB);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.PipstepCoefficient4_TB);
            this.groupBox4.Location = new System.Drawing.Point(417, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 142);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Стратегия 4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Кол-во ордеров";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Начальный пипстеп";
            // 
            // Orders4_TB
            // 
            this.Orders4_TB.Location = new System.Drawing.Point(9, 71);
            this.Orders4_TB.Name = "Orders4_TB";
            this.Orders4_TB.Size = new System.Drawing.Size(113, 20);
            this.Orders4_TB.TabIndex = 25;
            this.Orders4_TB.Text = "6";
            // 
            // Pipstep4_TB
            // 
            this.Pipstep4_TB.Location = new System.Drawing.Point(9, 32);
            this.Pipstep4_TB.Name = "Pipstep4_TB";
            this.Pipstep4_TB.Size = new System.Drawing.Size(113, 20);
            this.Pipstep4_TB.TabIndex = 24;
            this.Pipstep4_TB.Text = "30";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Мульт. пипстепа";
            // 
            // PipstepCoefficient4_TB
            // 
            this.PipstepCoefficient4_TB.Location = new System.Drawing.Point(9, 110);
            this.PipstepCoefficient4_TB.Name = "PipstepCoefficient4_TB";
            this.PipstepCoefficient4_TB.Size = new System.Drawing.Size(113, 20);
            this.PipstepCoefficient4_TB.TabIndex = 26;
            this.PipstepCoefficient4_TB.Text = "1.2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Кредитное плечё";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Leverage_TB
            // 
            this.Leverage_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Leverage_TB.Location = new System.Drawing.Point(15, 66);
            this.Leverage_TB.Name = "Leverage_TB";
            this.Leverage_TB.Size = new System.Drawing.Size(128, 21);
            this.Leverage_TB.TabIndex = 5;
            this.Leverage_TB.Text = "500";
            this.Leverage_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Result_DGV
            // 
            this.Result_DGV.AllowUserToAddRows = false;
            this.Result_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Result_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type_C,
            this.Quotation_C,
            this.MainProfit_C,
            this.SupportProfit_C,
            this.ResultProfit_C,
            this.Margin_C,
            this.Level_C});
            this.Result_DGV.Location = new System.Drawing.Point(15, 280);
            this.Result_DGV.Name = "Result_DGV";
            this.Result_DGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Result_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Result_DGV.RowHeadersVisible = false;
            this.Result_DGV.RowTemplate.ReadOnly = true;
            this.Result_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Result_DGV.Size = new System.Drawing.Size(530, 299);
            this.Result_DGV.TabIndex = 27;
            // 
            // Type_C
            // 
            this.Type_C.HeaderText = "Тип";
            this.Type_C.Name = "Type_C";
            this.Type_C.ReadOnly = true;
            this.Type_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type_C.Width = 144;
            // 
            // Quotation_C
            // 
            this.Quotation_C.HeaderText = "Котировка";
            this.Quotation_C.Name = "Quotation_C";
            this.Quotation_C.ReadOnly = true;
            this.Quotation_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quotation_C.Width = 64;
            // 
            // MainProfit_C
            // 
            this.MainProfit_C.HeaderText = "Профит (глав.)";
            this.MainProfit_C.Name = "MainProfit_C";
            this.MainProfit_C.ReadOnly = true;
            this.MainProfit_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MainProfit_C.Width = 64;
            // 
            // SupportProfit_C
            // 
            this.SupportProfit_C.HeaderText = "Профит (всп.)";
            this.SupportProfit_C.Name = "SupportProfit_C";
            this.SupportProfit_C.ReadOnly = true;
            this.SupportProfit_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SupportProfit_C.Width = 56;
            // 
            // ResultProfit_C
            // 
            this.ResultProfit_C.HeaderText = "Профит";
            this.ResultProfit_C.Name = "ResultProfit_C";
            this.ResultProfit_C.ReadOnly = true;
            this.ResultProfit_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultProfit_C.Width = 64;
            // 
            // Margin_C
            // 
            this.Margin_C.HeaderText = "Маржа";
            this.Margin_C.Name = "Margin_C";
            this.Margin_C.ReadOnly = true;
            this.Margin_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Margin_C.Width = 56;
            // 
            // Level_C
            // 
            this.Level_C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Level_C.HeaderText = "Ур. маржи";
            this.Level_C.Name = "Level_C";
            this.Level_C.ReadOnly = true;
            this.Level_C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Balance_TB
            // 
            this.Balance_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_TB.Location = new System.Drawing.Point(149, 66);
            this.Balance_TB.Name = "Balance_TB";
            this.Balance_TB.Size = new System.Drawing.Size(128, 21);
            this.Balance_TB.TabIndex = 9;
            this.Balance_TB.Text = "300000";
            this.Balance_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(146, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Баланс счёта, $";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(146, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Символ (валютная пара)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Symbol_CB
            // 
            this.Symbol_CB.FormattingEnabled = true;
            this.Symbol_CB.Location = new System.Drawing.Point(149, 106);
            this.Symbol_CB.Name = "Symbol_CB";
            this.Symbol_CB.Size = new System.Drawing.Size(128, 21);
            this.Symbol_CB.TabIndex = 10;
            this.Symbol_CB.SelectedIndexChanged += new System.EventHandler(this.Symbol_CB_SelectedIndexChanged);
            this.Symbol_CB.Click += new System.EventHandler(this.Symbol_CB_Click);
            // 
            // SaveSymbol_B
            // 
            this.SaveSymbol_B.Location = new System.Drawing.Point(283, 107);
            this.SaveSymbol_B.Name = "SaveSymbol_B";
            this.SaveSymbol_B.Size = new System.Drawing.Size(128, 20);
            this.SaveSymbol_B.TabIndex = 11;
            this.SaveSymbol_B.Text = "Сохранить настройки";
            this.SaveSymbol_B.UseVisualStyleBackColor = true;
            this.SaveSymbol_B.Click += new System.EventHandler(this.SaveSymbol_B_Click);
            // 
            // FullCalculate_B
            // 
            this.FullCalculate_B.Location = new System.Drawing.Point(417, 88);
            this.FullCalculate_B.Name = "FullCalculate_B";
            this.FullCalculate_B.Size = new System.Drawing.Size(128, 20);
            this.FullCalculate_B.TabIndex = 14;
            this.FullCalculate_B.Text = "Расчёт всех пар";
            this.FullCalculate_B.UseVisualStyleBackColor = true;
            this.FullCalculate_B.Click += new System.EventHandler(this.FullCalculate_B_Click);
            // 
            // DeleteSymbol_B
            // 
            this.DeleteSymbol_B.Location = new System.Drawing.Point(283, 88);
            this.DeleteSymbol_B.Name = "DeleteSymbol_B";
            this.DeleteSymbol_B.Size = new System.Drawing.Size(128, 20);
            this.DeleteSymbol_B.TabIndex = 12;
            this.DeleteSymbol_B.Text = "Удалить настройки";
            this.DeleteSymbol_B.UseVisualStyleBackColor = true;
            this.DeleteSymbol_B.Click += new System.EventHandler(this.DeleteSymbol_B_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 102);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 26);
            this.label21.TabIndex = 36;
            this.label21.Text = "Курс\r\nк $:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuotationMain_TB
            // 
            this.QuotationMain_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuotationMain_TB.Location = new System.Drawing.Point(44, 107);
            this.QuotationMain_TB.Name = "QuotationMain_TB";
            this.QuotationMain_TB.Size = new System.Drawing.Size(44, 21);
            this.QuotationMain_TB.TabIndex = 6;
            this.QuotationMain_TB.Text = "1";
            this.QuotationMain_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "Прямой";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(89, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Обратный";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuotationSupport_TB
            // 
            this.QuotationSupport_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuotationSupport_TB.Location = new System.Drawing.Point(92, 107);
            this.QuotationSupport_TB.Name = "QuotationSupport_TB";
            this.QuotationSupport_TB.Size = new System.Drawing.Size(51, 21);
            this.QuotationSupport_TB.TabIndex = 39;
            this.QuotationSupport_TB.Text = "1";
            this.QuotationSupport_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 587);
            this.Controls.Add(this.QuotationSupport_TB);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.QuotationMain_TB);
            this.Controls.Add(this.DeleteSymbol_B);
            this.Controls.Add(this.FullCalculate_B);
            this.Controls.Add(this.SaveSymbol_B);
            this.Controls.Add(this.Symbol_CB);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Balance_TB);
            this.Controls.Add(this.Result_DGV);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Leverage_TB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Spred_TB);
            this.Controls.Add(this.Calculate_B);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DealSize_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Accuracy_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TakeProfit_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LotCoefficient_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartLot_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Анализатор настроек бота MT4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartLot_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LotCoefficient_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TakeProfit_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Accuracy_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DealSize_TB;
        private System.Windows.Forms.Button Calculate_B;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Spred_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Pipstep1_TB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Orders1_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PipstepCoefficient1_TB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Orders2_TB;
        private System.Windows.Forms.TextBox Pipstep2_TB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PipstepCoefficient2_TB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Orders3_TB;
        private System.Windows.Forms.TextBox Pipstep3_TB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PipstepCoefficient3_TB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Orders4_TB;
        private System.Windows.Forms.TextBox Pipstep4_TB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox PipstepCoefficient4_TB;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Leverage_TB;
        private System.Windows.Forms.DataGridView Result_DGV;
        private System.Windows.Forms.TextBox Balance_TB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox Symbol_CB;
        private System.Windows.Forms.Button SaveSymbol_B;
        private System.Windows.Forms.Button FullCalculate_B;
        private System.Windows.Forms.Button DeleteSymbol_B;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox QuotationMain_TB;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox QuotationSupport_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quotation_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainProfit_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupportProfit_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultProfit_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margin_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level_C;
    }
}

