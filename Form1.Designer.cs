namespace Macierze
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlZakladki = new System.Windows.Forms.TabControl();
            this.tabPageKokpit = new System.Windows.Forms.TabPage();
            this.btnDzialaniaNaMacierzach = new System.Windows.Forms.Button();
            this.btnKalkulatorObliczenNaMacierzach = new System.Windows.Forms.Button();
            this.tabPageMacierze = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRoznicaBiA = new System.Windows.Forms.Button();
            this.btnIloczynMacierzyAiB = new System.Windows.Forms.Button();
            this.btnRoznicaAiB = new System.Windows.Forms.Button();
            this.btnSumaMacierzyAiB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAkceptacjaWarMacierzaB = new System.Windows.Forms.Button();
            this.btnGenerujElementyMacierzyB = new System.Windows.Forms.Button();
            this.btnAkceptacjaWarMacierzaA = new System.Windows.Forms.Button();
            this.btnUtworzkontrolkęDataGridviewMacierzyB = new System.Windows.Forms.Button();
            this.btnGenerujElementyMacierzyA = new System.Windows.Forms.Button();
            this.btnUtworzKontrolkeA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLiczbaWierszy = new System.Windows.Forms.TextBox();
            this.txtLiczbaKolumn = new System.Windows.Forms.TextBox();
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu = new System.Windows.Forms.Button();
            this.tabPageLiczbyZespolone = new System.Windows.Forms.TabPage();
            this.btnPowrotDoKokpitu2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtCzescRzeczywistaA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCzescUrojonaA = new System.Windows.Forms.TextBox();
            this.txtCzescUrojonaD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCzescRzeczywistaD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCzescUrojonaB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCzescRzeczywistaB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCzescUrojonaE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCzescRzeczywistaE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grupboxKalkulator = new System.Windows.Forms.GroupBox();
            this.btnSumaAiB = new System.Windows.Forms.Button();
            this.btnIlorazAiB = new System.Windows.Forms.Button();
            this.btnIloczynAiB = new System.Windows.Forms.Button();
            this.btnRoznicaAB = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.btnZToMinusA = new System.Windows.Forms.Button();
            this.btnZsilniaA = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControlZakladki.SuspendLayout();
            this.tabPageKokpit.SuspendLayout();
            this.tabPageMacierze.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageLiczbyZespolone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grupboxKalkulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlZakladki
            // 
            this.tabControlZakladki.Controls.Add(this.tabPageKokpit);
            this.tabControlZakladki.Controls.Add(this.tabPageMacierze);
            this.tabControlZakladki.Controls.Add(this.tabPageLiczbyZespolone);
            this.tabControlZakladki.Location = new System.Drawing.Point(37, 12);
            this.tabControlZakladki.Name = "tabControlZakladki";
            this.tabControlZakladki.SelectedIndex = 0;
            this.tabControlZakladki.Size = new System.Drawing.Size(1223, 733);
            this.tabControlZakladki.TabIndex = 0;
            this.tabControlZakladki.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPageKokpit
            // 
            this.tabPageKokpit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPageKokpit.Controls.Add(this.btnDzialaniaNaMacierzach);
            this.tabPageKokpit.Controls.Add(this.btnKalkulatorObliczenNaMacierzach);
            this.tabPageKokpit.Location = new System.Drawing.Point(4, 22);
            this.tabPageKokpit.Name = "tabPageKokpit";
            this.tabPageKokpit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKokpit.Size = new System.Drawing.Size(1215, 707);
            this.tabPageKokpit.TabIndex = 0;
            this.tabPageKokpit.Text = "Kokpit";
            // 
            // btnDzialaniaNaMacierzach
            // 
            this.btnDzialaniaNaMacierzach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzialaniaNaMacierzach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDzialaniaNaMacierzach.Location = new System.Drawing.Point(647, 247);
            this.btnDzialaniaNaMacierzach.Name = "btnDzialaniaNaMacierzach";
            this.btnDzialaniaNaMacierzach.Size = new System.Drawing.Size(215, 86);
            this.btnDzialaniaNaMacierzach.TabIndex = 1;
            this.btnDzialaniaNaMacierzach.Text = "Kalulator obliczeń na liczbach zespolonych";
            this.btnDzialaniaNaMacierzach.UseVisualStyleBackColor = true;
            this.btnDzialaniaNaMacierzach.Click += new System.EventHandler(this.btnDzialaniaNaMacierzach_Click);
            // 
            // btnKalkulatorObliczenNaMacierzach
            // 
            this.btnKalkulatorObliczenNaMacierzach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKalkulatorObliczenNaMacierzach.Location = new System.Drawing.Point(243, 247);
            this.btnKalkulatorObliczenNaMacierzach.Name = "btnKalkulatorObliczenNaMacierzach";
            this.btnKalkulatorObliczenNaMacierzach.Size = new System.Drawing.Size(215, 86);
            this.btnKalkulatorObliczenNaMacierzach.TabIndex = 0;
            this.btnKalkulatorObliczenNaMacierzach.Text = "Kalkulator obliczeń na macierzach";
            this.btnKalkulatorObliczenNaMacierzach.UseVisualStyleBackColor = true;
            this.btnKalkulatorObliczenNaMacierzach.Click += new System.EventHandler(this.btnKalkulatorObliczenNaMacierzach_Click);
            // 
            // tabPageMacierze
            // 
            this.tabPageMacierze.BackColor = System.Drawing.Color.Silver;
            this.tabPageMacierze.Controls.Add(this.groupBox3);
            this.tabPageMacierze.Controls.Add(this.groupBox2);
            this.tabPageMacierze.Controls.Add(this.groupBox1);
            this.tabPageMacierze.Controls.Add(this.btnDzialaniaNaMacierzachPowrotDoKokpitu);
            this.tabPageMacierze.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacierze.Name = "tabPageMacierze";
            this.tabPageMacierze.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacierze.Size = new System.Drawing.Size(1215, 707);
            this.tabPageMacierze.TabIndex = 1;
            this.tabPageMacierze.Text = "Działania na macierzach";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRoznicaBiA);
            this.groupBox3.Controls.Add(this.btnIloczynMacierzyAiB);
            this.groupBox3.Controls.Add(this.btnRoznicaAiB);
            this.groupBox3.Controls.Add(this.btnSumaMacierzyAiB);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(39, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 320);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kalkulator działań na macierzach";
            // 
            // btnRoznicaBiA
            // 
            this.btnRoznicaBiA.Enabled = false;
            this.btnRoznicaBiA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRoznicaBiA.Location = new System.Drawing.Point(53, 169);
            this.btnRoznicaBiA.Name = "btnRoznicaBiA";
            this.btnRoznicaBiA.Size = new System.Drawing.Size(162, 54);
            this.btnRoznicaBiA.TabIndex = 20;
            this.btnRoznicaBiA.Text = "C = B - A";
            this.btnRoznicaBiA.UseVisualStyleBackColor = true;
            this.btnRoznicaBiA.Click += new System.EventHandler(this.btnRoznicaBiA_Click);
            // 
            // btnIloczynMacierzyAiB
            // 
            this.btnIloczynMacierzyAiB.Enabled = false;
            this.btnIloczynMacierzyAiB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIloczynMacierzyAiB.Location = new System.Drawing.Point(53, 242);
            this.btnIloczynMacierzyAiB.Name = "btnIloczynMacierzyAiB";
            this.btnIloczynMacierzyAiB.Size = new System.Drawing.Size(162, 54);
            this.btnIloczynMacierzyAiB.TabIndex = 19;
            this.btnIloczynMacierzyAiB.Text = "C = A * B\r\n";
            this.btnIloczynMacierzyAiB.UseVisualStyleBackColor = true;
            this.btnIloczynMacierzyAiB.Click += new System.EventHandler(this.btnIloczynMacierzyAiB_Click);
            // 
            // btnRoznicaAiB
            // 
            this.btnRoznicaAiB.Enabled = false;
            this.btnRoznicaAiB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRoznicaAiB.Location = new System.Drawing.Point(53, 100);
            this.btnRoznicaAiB.Name = "btnRoznicaAiB";
            this.btnRoznicaAiB.Size = new System.Drawing.Size(162, 54);
            this.btnRoznicaAiB.TabIndex = 18;
            this.btnRoznicaAiB.Text = "C = A - B\r\n";
            this.btnRoznicaAiB.UseVisualStyleBackColor = true;
            this.btnRoznicaAiB.Click += new System.EventHandler(this.btnRoznicaAiB_Click);
            // 
            // btnSumaMacierzyAiB
            // 
            this.btnSumaMacierzyAiB.Enabled = false;
            this.btnSumaMacierzyAiB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSumaMacierzyAiB.Location = new System.Drawing.Point(53, 40);
            this.btnSumaMacierzyAiB.Name = "btnSumaMacierzyAiB";
            this.btnSumaMacierzyAiB.Size = new System.Drawing.Size(162, 54);
            this.btnSumaMacierzyAiB.TabIndex = 17;
            this.btnSumaMacierzyAiB.Text = "C = A + B\r\n";
            this.btnSumaMacierzyAiB.UseVisualStyleBackColor = true;
            this.btnSumaMacierzyAiB.Click += new System.EventHandler(this.btnSumaMacierzyAiB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAkceptacjaWarMacierzaB);
            this.groupBox2.Controls.Add(this.btnGenerujElementyMacierzyB);
            this.groupBox2.Controls.Add(this.btnAkceptacjaWarMacierzaA);
            this.groupBox2.Controls.Add(this.btnUtworzkontrolkęDataGridviewMacierzyB);
            this.groupBox2.Controls.Add(this.btnGenerujElementyMacierzyA);
            this.groupBox2.Controls.Add(this.btnUtworzKontrolkeA);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(904, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 626);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Przyciski operacyjne";
            // 
            // btnAkceptacjaWarMacierzaB
            // 
            this.btnAkceptacjaWarMacierzaB.Enabled = false;
            this.btnAkceptacjaWarMacierzaB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAkceptacjaWarMacierzaB.Location = new System.Drawing.Point(15, 512);
            this.btnAkceptacjaWarMacierzaB.Name = "btnAkceptacjaWarMacierzaB";
            this.btnAkceptacjaWarMacierzaB.Size = new System.Drawing.Size(203, 60);
            this.btnAkceptacjaWarMacierzaB.TabIndex = 12;
            this.btnAkceptacjaWarMacierzaB.Text = "Akceptacja wartośći elementów macierzy B\r\n";
            this.btnAkceptacjaWarMacierzaB.UseVisualStyleBackColor = true;
            this.btnAkceptacjaWarMacierzaB.Click += new System.EventHandler(this.btnAkceptacjaWarMacierzaB_Click);
            // 
            // btnGenerujElementyMacierzyB
            // 
            this.btnGenerujElementyMacierzyB.Enabled = false;
            this.btnGenerujElementyMacierzyB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerujElementyMacierzyB.Location = new System.Drawing.Point(15, 446);
            this.btnGenerujElementyMacierzyB.Name = "btnGenerujElementyMacierzyB";
            this.btnGenerujElementyMacierzyB.Size = new System.Drawing.Size(203, 60);
            this.btnGenerujElementyMacierzyB.TabIndex = 13;
            this.btnGenerujElementyMacierzyB.Text = "Wygeneruj wartości\r\nelementów macierzy B";
            this.btnGenerujElementyMacierzyB.UseVisualStyleBackColor = true;
            this.btnGenerujElementyMacierzyB.Click += new System.EventHandler(this.btnGenerujElementyMacierzyB_Click);
            // 
            // btnAkceptacjaWarMacierzaA
            // 
            this.btnAkceptacjaWarMacierzaA.Enabled = false;
            this.btnAkceptacjaWarMacierzaA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAkceptacjaWarMacierzaA.Location = new System.Drawing.Point(15, 206);
            this.btnAkceptacjaWarMacierzaA.Name = "btnAkceptacjaWarMacierzaA";
            this.btnAkceptacjaWarMacierzaA.Size = new System.Drawing.Size(203, 60);
            this.btnAkceptacjaWarMacierzaA.TabIndex = 10;
            this.btnAkceptacjaWarMacierzaA.Text = "Akceptacja wartośći elementów macierzy A\r\n";
            this.btnAkceptacjaWarMacierzaA.UseVisualStyleBackColor = true;
            this.btnAkceptacjaWarMacierzaA.Click += new System.EventHandler(this.btnAkceptacjaWarMacierzaA_Click);
            // 
            // btnUtworzkontrolkęDataGridviewMacierzyB
            // 
            this.btnUtworzkontrolkęDataGridviewMacierzyB.Enabled = false;
            this.btnUtworzkontrolkęDataGridviewMacierzyB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzkontrolkęDataGridviewMacierzyB.Location = new System.Drawing.Point(15, 346);
            this.btnUtworzkontrolkęDataGridviewMacierzyB.Name = "btnUtworzkontrolkęDataGridviewMacierzyB";
            this.btnUtworzkontrolkęDataGridviewMacierzyB.Size = new System.Drawing.Size(203, 81);
            this.btnUtworzkontrolkęDataGridviewMacierzyB.TabIndex = 9;
            this.btnUtworzkontrolkęDataGridviewMacierzyB.Text = "Utwórz kontrolkę \r\nDataGridView dla \r\nmacierzy B";
            this.btnUtworzkontrolkęDataGridviewMacierzyB.UseVisualStyleBackColor = true;
            this.btnUtworzkontrolkęDataGridviewMacierzyB.Click += new System.EventHandler(this.btnUtworzkontrolkęDataGridviewMacierzyB_Click);
            // 
            // btnGenerujElementyMacierzyA
            // 
            this.btnGenerujElementyMacierzyA.Enabled = false;
            this.btnGenerujElementyMacierzyA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerujElementyMacierzyA.Location = new System.Drawing.Point(15, 140);
            this.btnGenerujElementyMacierzyA.Name = "btnGenerujElementyMacierzyA";
            this.btnGenerujElementyMacierzyA.Size = new System.Drawing.Size(203, 60);
            this.btnGenerujElementyMacierzyA.TabIndex = 11;
            this.btnGenerujElementyMacierzyA.Text = "Wygeneruj wartości\r\nelementów macierzy A\r\n";
            this.btnGenerujElementyMacierzyA.UseVisualStyleBackColor = true;
            this.btnGenerujElementyMacierzyA.Click += new System.EventHandler(this.btnGenerujElementyMacierzyA_Click);
            // 
            // btnUtworzKontrolkeA
            // 
            this.btnUtworzKontrolkeA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzKontrolkeA.Location = new System.Drawing.Point(15, 38);
            this.btnUtworzKontrolkeA.Name = "btnUtworzKontrolkeA";
            this.btnUtworzKontrolkeA.Size = new System.Drawing.Size(203, 86);
            this.btnUtworzKontrolkeA.TabIndex = 8;
            this.btnUtworzKontrolkeA.Text = "Utwórz kontrolkę \r\nDataGridView dla \r\nmacierzy A\r\n";
            this.btnUtworzKontrolkeA.UseVisualStyleBackColor = true;
            this.btnUtworzKontrolkeA.Click += new System.EventHandler(this.btnUtworzKontrolkeA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLiczbaWierszy);
            this.groupBox1.Controls.Add(this.txtLiczbaKolumn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(39, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wymiary macierzy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba wierszy macierzy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liczba kolumn macierzy";
            // 
            // txtLiczbaWierszy
            // 
            this.txtLiczbaWierszy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLiczbaWierszy.Location = new System.Drawing.Point(183, 34);
            this.txtLiczbaWierszy.Name = "txtLiczbaWierszy";
            this.txtLiczbaWierszy.Size = new System.Drawing.Size(100, 26);
            this.txtLiczbaWierszy.TabIndex = 2;
            // 
            // txtLiczbaKolumn
            // 
            this.txtLiczbaKolumn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLiczbaKolumn.Location = new System.Drawing.Point(183, 89);
            this.txtLiczbaKolumn.Name = "txtLiczbaKolumn";
            this.txtLiczbaKolumn.Size = new System.Drawing.Size(100, 26);
            this.txtLiczbaKolumn.TabIndex = 4;
            // 
            // btnDzialaniaNaMacierzachPowrotDoKokpitu
            // 
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.Location = new System.Drawing.Point(39, 47);
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.Name = "btnDzialaniaNaMacierzachPowrotDoKokpitu";
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.Size = new System.Drawing.Size(215, 86);
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.TabIndex = 1;
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.Text = "Powrót do kokpitu";
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.UseVisualStyleBackColor = true;
            this.btnDzialaniaNaMacierzachPowrotDoKokpitu.Click += new System.EventHandler(this.btnDzialaniaNaMacierzachPowrotDoKokpitu_Click);
            // 
            // tabPageLiczbyZespolone
            // 
            this.tabPageLiczbyZespolone.BackColor = System.Drawing.Color.Coral;
            this.tabPageLiczbyZespolone.Controls.Add(this.txtWynik);
            this.tabPageLiczbyZespolone.Controls.Add(this.label15);
            this.tabPageLiczbyZespolone.Controls.Add(this.grupboxKalkulator);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescUrojonaE);
            this.tabPageLiczbyZespolone.Controls.Add(this.label12);
            this.tabPageLiczbyZespolone.Controls.Add(this.label13);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescRzeczywistaE);
            this.tabPageLiczbyZespolone.Controls.Add(this.label14);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescUrojonaB);
            this.tabPageLiczbyZespolone.Controls.Add(this.label9);
            this.tabPageLiczbyZespolone.Controls.Add(this.label10);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescRzeczywistaB);
            this.tabPageLiczbyZespolone.Controls.Add(this.label11);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescUrojonaD);
            this.tabPageLiczbyZespolone.Controls.Add(this.label6);
            this.tabPageLiczbyZespolone.Controls.Add(this.label7);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescRzeczywistaD);
            this.tabPageLiczbyZespolone.Controls.Add(this.label8);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescUrojonaA);
            this.tabPageLiczbyZespolone.Controls.Add(this.label5);
            this.tabPageLiczbyZespolone.Controls.Add(this.label4);
            this.tabPageLiczbyZespolone.Controls.Add(this.txtCzescRzeczywistaA);
            this.tabPageLiczbyZespolone.Controls.Add(this.label3);
            this.tabPageLiczbyZespolone.Controls.Add(this.btnPowrotDoKokpitu2);
            this.tabPageLiczbyZespolone.Location = new System.Drawing.Point(4, 22);
            this.tabPageLiczbyZespolone.Name = "tabPageLiczbyZespolone";
            this.tabPageLiczbyZespolone.Size = new System.Drawing.Size(1215, 707);
            this.tabPageLiczbyZespolone.TabIndex = 2;
            this.tabPageLiczbyZespolone.Text = "Działania na liczbach zaspolonych";
            // 
            // btnPowrotDoKokpitu2
            // 
            this.btnPowrotDoKokpitu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPowrotDoKokpitu2.Location = new System.Drawing.Point(35, 36);
            this.btnPowrotDoKokpitu2.Name = "btnPowrotDoKokpitu2";
            this.btnPowrotDoKokpitu2.Size = new System.Drawing.Size(215, 86);
            this.btnPowrotDoKokpitu2.TabIndex = 2;
            this.btnPowrotDoKokpitu2.Text = "Powrót do kokpitu";
            this.btnPowrotDoKokpitu2.UseVisualStyleBackColor = true;
            this.btnPowrotDoKokpitu2.Click += new System.EventHandler(this.btnPowrotDoKokpitu2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(90, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "A = ";
            // 
            // txtCzescRzeczywistaA
            // 
            this.txtCzescRzeczywistaA.Location = new System.Drawing.Point(150, 203);
            this.txtCzescRzeczywistaA.Name = "txtCzescRzeczywistaA";
            this.txtCzescRzeczywistaA.Size = new System.Drawing.Size(100, 20);
            this.txtCzescRzeczywistaA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(291, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Część Urojona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(147, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Część Rzeczywista";
            // 
            // txtCzescUrojonaA
            // 
            this.txtCzescUrojonaA.Location = new System.Drawing.Point(284, 203);
            this.txtCzescUrojonaA.Name = "txtCzescUrojonaA";
            this.txtCzescUrojonaA.Size = new System.Drawing.Size(100, 20);
            this.txtCzescUrojonaA.TabIndex = 7;
            // 
            // txtCzescUrojonaD
            // 
            this.txtCzescUrojonaD.Location = new System.Drawing.Point(284, 364);
            this.txtCzescUrojonaD.Name = "txtCzescUrojonaD";
            this.txtCzescUrojonaD.Size = new System.Drawing.Size(100, 20);
            this.txtCzescUrojonaD.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(147, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Część Rzeczywista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(291, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Część Urojona";
            // 
            // txtCzescRzeczywistaD
            // 
            this.txtCzescRzeczywistaD.Location = new System.Drawing.Point(150, 364);
            this.txtCzescRzeczywistaD.Name = "txtCzescRzeczywistaD";
            this.txtCzescRzeczywistaD.Size = new System.Drawing.Size(100, 20);
            this.txtCzescRzeczywistaD.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(90, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "D = ";
            // 
            // txtCzescUrojonaB
            // 
            this.txtCzescUrojonaB.Location = new System.Drawing.Point(284, 289);
            this.txtCzescUrojonaB.Name = "txtCzescUrojonaB";
            this.txtCzescUrojonaB.Size = new System.Drawing.Size(100, 20);
            this.txtCzescUrojonaB.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(147, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Część Rzeczywista";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(291, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Część Urojona";
            // 
            // txtCzescRzeczywistaB
            // 
            this.txtCzescRzeczywistaB.Location = new System.Drawing.Point(150, 289);
            this.txtCzescRzeczywistaB.Name = "txtCzescRzeczywistaB";
            this.txtCzescRzeczywistaB.Size = new System.Drawing.Size(100, 20);
            this.txtCzescRzeczywistaB.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(90, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "B = ";
            // 
            // txtCzescUrojonaE
            // 
            this.txtCzescUrojonaE.Location = new System.Drawing.Point(284, 439);
            this.txtCzescUrojonaE.Name = "txtCzescUrojonaE";
            this.txtCzescUrojonaE.Size = new System.Drawing.Size(100, 20);
            this.txtCzescUrojonaE.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(147, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Część Rzeczywista";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(291, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Część Urojona";
            // 
            // txtCzescRzeczywistaE
            // 
            this.txtCzescRzeczywistaE.Location = new System.Drawing.Point(150, 439);
            this.txtCzescRzeczywistaE.Name = "txtCzescRzeczywistaE";
            this.txtCzescRzeczywistaE.Size = new System.Drawing.Size(100, 20);
            this.txtCzescRzeczywistaE.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(90, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 26);
            this.label14.TabIndex = 18;
            this.label14.Text = "E = ";
            // 
            // grupboxKalkulator
            // 
            this.grupboxKalkulator.Controls.Add(this.button3);
            this.grupboxKalkulator.Controls.Add(this.btnZsilniaA);
            this.grupboxKalkulator.Controls.Add(this.btnZToMinusA);
            this.grupboxKalkulator.Controls.Add(this.btnRoznicaAB);
            this.grupboxKalkulator.Controls.Add(this.btnIloczynAiB);
            this.grupboxKalkulator.Controls.Add(this.btnIlorazAiB);
            this.grupboxKalkulator.Controls.Add(this.btnSumaAiB);
            this.grupboxKalkulator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grupboxKalkulator.Location = new System.Drawing.Point(541, 36);
            this.grupboxKalkulator.Name = "grupboxKalkulator";
            this.grupboxKalkulator.Size = new System.Drawing.Size(625, 497);
            this.grupboxKalkulator.TabIndex = 23;
            this.grupboxKalkulator.TabStop = false;
            this.grupboxKalkulator.Text = "Kalkulator";
            // 
            // btnSumaAiB
            // 
            this.btnSumaAiB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSumaAiB.Location = new System.Drawing.Point(65, 65);
            this.btnSumaAiB.Name = "btnSumaAiB";
            this.btnSumaAiB.Size = new System.Drawing.Size(120, 51);
            this.btnSumaAiB.TabIndex = 0;
            this.btnSumaAiB.Text = "C = A + B";
            this.btnSumaAiB.UseVisualStyleBackColor = true;
            this.btnSumaAiB.Click += new System.EventHandler(this.btnSumaAiB_Click);
            // 
            // btnIlorazAiB
            // 
            this.btnIlorazAiB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIlorazAiB.Location = new System.Drawing.Point(65, 297);
            this.btnIlorazAiB.Name = "btnIlorazAiB";
            this.btnIlorazAiB.Size = new System.Drawing.Size(120, 51);
            this.btnIlorazAiB.TabIndex = 6;
            this.btnIlorazAiB.Text = "C = A / B";
            this.btnIlorazAiB.UseVisualStyleBackColor = true;
            this.btnIlorazAiB.Click += new System.EventHandler(this.btnIlorazAiB_Click);
            // 
            // btnIloczynAiB
            // 
            this.btnIloczynAiB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIloczynAiB.Location = new System.Drawing.Point(65, 216);
            this.btnIloczynAiB.Name = "btnIloczynAiB";
            this.btnIloczynAiB.Size = new System.Drawing.Size(120, 51);
            this.btnIloczynAiB.TabIndex = 7;
            this.btnIloczynAiB.Text = "C = A * B";
            this.btnIloczynAiB.UseVisualStyleBackColor = true;
            this.btnIloczynAiB.Click += new System.EventHandler(this.btnIloczynAiB_Click);
            // 
            // btnRoznicaAB
            // 
            this.btnRoznicaAB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRoznicaAB.Location = new System.Drawing.Point(65, 136);
            this.btnRoznicaAB.Name = "btnRoznicaAB";
            this.btnRoznicaAB.Size = new System.Drawing.Size(120, 51);
            this.btnRoznicaAB.TabIndex = 8;
            this.btnRoznicaAB.Text = "C = A - B";
            this.btnRoznicaAB.UseVisualStyleBackColor = true;
            this.btnRoznicaAB.Click += new System.EventHandler(this.btnRoznicaAB_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(844, 547);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 26);
            this.label15.TabIndex = 24;
            this.label15.Text = "WYNIK";
            // 
            // txtWynik
            // 
            this.txtWynik.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWynik.Location = new System.Drawing.Point(732, 576);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.Size = new System.Drawing.Size(313, 32);
            this.txtWynik.TabIndex = 25;
            this.txtWynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnZToMinusA
            // 
            this.btnZToMinusA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZToMinusA.Location = new System.Drawing.Point(415, 65);
            this.btnZToMinusA.Name = "btnZToMinusA";
            this.btnZToMinusA.Size = new System.Drawing.Size(120, 51);
            this.btnZToMinusA.TabIndex = 9;
            this.btnZToMinusA.Text = "Z = -A";
            this.btnZToMinusA.UseVisualStyleBackColor = true;
            this.btnZToMinusA.Click += new System.EventHandler(this.btnZToMinusA_Click);
            // 
            // btnZsilniaA
            // 
            this.btnZsilniaA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZsilniaA.Location = new System.Drawing.Point(252, 65);
            this.btnZsilniaA.Name = "btnZsilniaA";
            this.btnZsilniaA.Size = new System.Drawing.Size(120, 51);
            this.btnZsilniaA.TabIndex = 10;
            this.btnZsilniaA.Text = "Z = !A";
            this.btnZsilniaA.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(267, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 51);
            this.button3.TabIndex = 11;
            this.button3.Text = "RESETUJ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 774);
            this.Controls.Add(this.tabControlZakladki);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlZakladki.ResumeLayout(false);
            this.tabPageKokpit.ResumeLayout(false);
            this.tabPageMacierze.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageLiczbyZespolone.ResumeLayout(false);
            this.tabPageLiczbyZespolone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grupboxKalkulator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlZakladki;
        private System.Windows.Forms.TabPage tabPageKokpit;
        private System.Windows.Forms.TabPage tabPageMacierze;
        private System.Windows.Forms.TabPage tabPageLiczbyZespolone;
        private System.Windows.Forms.Button btnKalkulatorObliczenNaMacierzach;
        private System.Windows.Forms.Button btnDzialaniaNaMacierzach;
        private System.Windows.Forms.Button btnDzialaniaNaMacierzachPowrotDoKokpitu;
        private System.Windows.Forms.Button btnPowrotDoKokpitu2;
        private System.Windows.Forms.TextBox txtLiczbaWierszy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLiczbaKolumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnUtworzKontrolkeA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUtworzkontrolkęDataGridviewMacierzyB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAkceptacjaWarMacierzaA;
        private System.Windows.Forms.Button btnGenerujElementyMacierzyA;
        private System.Windows.Forms.Button btnAkceptacjaWarMacierzaB;
        private System.Windows.Forms.Button btnGenerujElementyMacierzyB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRoznicaBiA;
        private System.Windows.Forms.Button btnIloczynMacierzyAiB;
        private System.Windows.Forms.Button btnRoznicaAiB;
        private System.Windows.Forms.Button btnSumaMacierzyAiB;
        private System.Windows.Forms.TextBox txtCzescUrojonaA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCzescRzeczywistaA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCzescUrojonaE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCzescRzeczywistaE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCzescUrojonaB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCzescRzeczywistaB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCzescUrojonaD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCzescRzeczywistaD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grupboxKalkulator;
        private System.Windows.Forms.Button btnRoznicaAB;
        private System.Windows.Forms.Button btnIloczynAiB;
        private System.Windows.Forms.Button btnIlorazAiB;
        private System.Windows.Forms.Button btnSumaAiB;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnZsilniaA;
        private System.Windows.Forms.Button btnZToMinusA;
    }
}

