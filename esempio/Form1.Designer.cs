namespace esempio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tempC = new Label();
            text1 = new TextBox();
            conv1 = new Button();
            ris1 = new Label();
            ris2 = new Label();
            conv2 = new Button();
            text2 = new TextBox();
            tempF = new Label();
            lista = new ListBox();
            text3 = new TextBox();
            svuota = new Button();
            agg = new Button();
            somma = new Button();
            sottrazione = new Button();
            molt = new Button();
            div = new Button();
            textB1 = new TextBox();
            textB2 = new TextBox();
            n1 = new Label();
            n2 = new Label();
            risu = new Label();
            SuspendLayout();
            // 
            // tempC
            // 
            tempC.AutoSize = true;
            tempC.Location = new Point(12, 9);
            tempC.Name = "tempC";
            tempC.Size = new Size(81, 15);
            tempC.TabIndex = 0;
            tempC.Text = "TemperaturaC";
            // 
            // text1
            // 
            text1.Location = new Point(12, 27);
            text1.Name = "text1";
            text1.Size = new Size(100, 23);
            text1.TabIndex = 1;
            // 
            // conv1
            // 
            conv1.Location = new Point(154, 27);
            conv1.Name = "conv1";
            conv1.Size = new Size(75, 23);
            conv1.TabIndex = 2;
            conv1.Text = "Converti";
            conv1.UseVisualStyleBackColor = true;
            conv1.Click += conv1_Click;
            // 
            // ris1
            // 
            ris1.AutoSize = true;
            ris1.Location = new Point(295, 31);
            ris1.Name = "ris1";
            ris1.Size = new Size(0, 15);
            ris1.TabIndex = 3;
            // 
            // ris2
            // 
            ris2.AutoSize = true;
            ris2.Location = new Point(295, 129);
            ris2.Name = "ris2";
            ris2.Size = new Size(0, 15);
            ris2.TabIndex = 7;
            // 
            // conv2
            // 
            conv2.Location = new Point(154, 125);
            conv2.Name = "conv2";
            conv2.Size = new Size(75, 23);
            conv2.TabIndex = 6;
            conv2.Text = "Converti";
            conv2.UseVisualStyleBackColor = true;
            conv2.Click += conv2_Click;
            // 
            // text2
            // 
            text2.Location = new Point(12, 125);
            text2.Name = "text2";
            text2.Size = new Size(100, 23);
            text2.TabIndex = 5;
            // 
            // tempF
            // 
            tempF.AutoSize = true;
            tempF.Location = new Point(12, 107);
            tempF.Name = "tempF";
            tempF.Size = new Size(79, 15);
            tempF.TabIndex = 4;
            tempF.Text = "TemperaturaF";
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(12, 247);
            lista.Name = "lista";
            lista.Size = new Size(120, 94);
            lista.TabIndex = 8;
            // 
            // text3
            // 
            text3.Location = new Point(12, 218);
            text3.Name = "text3";
            text3.Size = new Size(100, 23);
            text3.TabIndex = 9;
            // 
            // svuota
            // 
            svuota.Location = new Point(182, 268);
            svuota.Name = "svuota";
            svuota.Size = new Size(75, 23);
            svuota.TabIndex = 10;
            svuota.Text = "svuota lista";
            svuota.UseVisualStyleBackColor = true;
            svuota.Click += svuota_Click;
            // 
            // agg
            // 
            agg.Location = new Point(182, 217);
            agg.Name = "agg";
            agg.Size = new Size(75, 23);
            agg.TabIndex = 11;
            agg.Text = "aggiungi";
            agg.UseVisualStyleBackColor = true;
            agg.Click += agg_Click;
            // 
            // somma
            // 
            somma.Location = new Point(658, 134);
            somma.Name = "somma";
            somma.Size = new Size(75, 23);
            somma.TabIndex = 12;
            somma.Text = "+";
            somma.UseVisualStyleBackColor = true;
            somma.Click += somma_Click;
            // 
            // sottrazione
            // 
            sottrazione.Location = new Point(765, 134);
            sottrazione.Name = "sottrazione";
            sottrazione.Size = new Size(75, 23);
            sottrazione.TabIndex = 13;
            sottrazione.Text = "-";
            sottrazione.UseVisualStyleBackColor = true;
            sottrazione.Click += sottrazione_Click;
            // 
            // molt
            // 
            molt.Location = new Point(658, 172);
            molt.Name = "molt";
            molt.Size = new Size(75, 23);
            molt.TabIndex = 14;
            molt.Text = "*";
            molt.UseVisualStyleBackColor = true;
            molt.Click += molt_Click;
            // 
            // div
            // 
            div.Location = new Point(765, 172);
            div.Name = "div";
            div.Size = new Size(75, 23);
            div.TabIndex = 15;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // textB1
            // 
            textB1.Location = new Point(488, 107);
            textB1.Name = "textB1";
            textB1.Size = new Size(100, 23);
            textB1.TabIndex = 16;
            // 
            // textB2
            // 
            textB2.Location = new Point(488, 173);
            textB2.Name = "textB2";
            textB2.Size = new Size(100, 23);
            textB2.TabIndex = 17;
            // 
            // n1
            // 
            n1.AutoSize = true;
            n1.Location = new Point(488, 89);
            n1.Name = "n1";
            n1.Size = new Size(55, 15);
            n1.TabIndex = 19;
            n1.Text = "numero1";
            // 
            // n2
            // 
            n2.AutoSize = true;
            n2.Location = new Point(488, 155);
            n2.Name = "n2";
            n2.Size = new Size(55, 15);
            n2.TabIndex = 20;
            n2.Text = "numero2";
            // 
            // risu
            // 
            risu.AutoSize = true;
            risu.Location = new Point(624, 226);
            risu.Name = "risu";
            risu.Size = new Size(0, 15);
            risu.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 632);
            Controls.Add(risu);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(textB2);
            Controls.Add(textB1);
            Controls.Add(div);
            Controls.Add(molt);
            Controls.Add(sottrazione);
            Controls.Add(somma);
            Controls.Add(agg);
            Controls.Add(svuota);
            Controls.Add(text3);
            Controls.Add(lista);
            Controls.Add(ris2);
            Controls.Add(conv2);
            Controls.Add(text2);
            Controls.Add(tempF);
            Controls.Add(ris1);
            Controls.Add(conv1);
            Controls.Add(text1);
            Controls.Add(tempC);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tempC;
        private TextBox text1;
        private Button conv1;
        private Label ris1;
        private Label ris2;
        private Button conv2;
        private TextBox text2;
        private Label tempF;
        private ListBox lista;
        private TextBox text3;
        private Button svuota;
        private Button agg;
        private Button somma;
        private Button sottrazione;
        private Button molt;
        private Button div;
        private TextBox textB1;
        private TextBox textB2;
        private Label n1;
        private Label n2;
        private Label risu;
    }
}
