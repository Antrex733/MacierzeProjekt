using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macierze
{
    public partial class Form1 : Form
    {
        bool[] StanStronZakladki = { true, false, false };
        DataGridView dgvMacierzA;
        DataGridView dgvMacierzB;
        DataGridView dgvMacierzC;
        int DolnaGranicaPrzedzialu = 10;
        int GornaGranicaPrzedzialu = 100;
        Macierz A;
        Macierz B;
        Macierz C;
        Zespolona zA;
        Zespolona zB;
        Zespolona zD;
        Zespolona zE;
        Zespolona zC;
        Zespolona zZ;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabControlZakladki.TabPages[0])
            {
                if (StanStronZakladki[0])
                {
                    e.Cancel = false;
                    tabControlZakladki.SelectedTab = tabPageKokpit;
                }
                else
                    e.Cancel = true;
            }

            if (e.TabPage == tabControlZakladki.TabPages[1])
            {
                if (StanStronZakladki[1])
                {
                    e.Cancel = false;
                    tabControlZakladki.SelectedTab = tabPageMacierze;
                }
                else
                    e.Cancel = true;
            }

            if (e.TabPage == tabControlZakladki.TabPages[2])
            {
                if (StanStronZakladki[2])
                {
                    e.Cancel = false;
                    tabControlZakladki.SelectedTab = tabPageLiczbyZespolone;
                }
                else
                    e.Cancel = true;
            }
        }

        private void btnKalkulatorObliczenNaMacierzach_Click(object sender, EventArgs e)
        {
            StanStronZakladki[0] = false;
            StanStronZakladki[1] = true;
            tabControlZakladki.SelectedTab = tabPageMacierze;

        }

        private void btnDzialaniaNaMacierzach_Click(object sender, EventArgs e)
        {
            StanStronZakladki[0] = false;
            StanStronZakladki[2] = true;
            tabControlZakladki.SelectedTab = tabPageLiczbyZespolone;
        }

        private void btnDzialaniaNaMacierzachPowrotDoKokpitu_Click(object sender, EventArgs e)
        {
            StanStronZakladki[1] = false;
            StanStronZakladki[0] = true;
            tabControlZakladki.SelectedTab = tabPageKokpit;
        }

        private void btnPowrotDoKokpitu2_Click(object sender, EventArgs e)
        {
            StanStronZakladki[2] = false;
            StanStronZakladki[0] = true;
            tabControlZakladki.SelectedTab = tabPageKokpit;
        }

        private void btnUtworzKontrolkeA_Click(object sender, EventArgs e)
        {
            ushort Odstep = 10;
            ushort SzerokoscKolumny = 70;
            ushort WysokoscWiersza = 25;
            ushort LiczbaWierszyMacierzy;
            ushort LiczbaKolulmMacierzy;

            errorProvider1.Dispose();

            if (!ushort.TryParse(txtLiczbaWierszy.Text, out LiczbaWierszyMacierzy))
            {
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: Niedozwolona wartość (tylko liczby naturalne)");
                return;
            }
            if (!ushort.TryParse(txtLiczbaKolumn.Text, out LiczbaKolulmMacierzy))
            {
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: Niedozwolona wartość (tylko liczby naturalne)");
                return;
            }
            //Właściwości dgvMacierzA
            dgvMacierzA = new DataGridView();

            //Lokalizacja
            dgvMacierzA.Location = new Point(groupBox1.Location.X + groupBox1.Width + Odstep,
                btnPowrotDoKokpitu2.Top);

            //Rozmiar
            dgvMacierzA.Size = new Size((LiczbaKolulmMacierzy + 1) * SzerokoscKolumny,
                (LiczbaWierszyMacierzy + 1) * WysokoscWiersza);

            dgvMacierzA.ColumnCount = LiczbaKolulmMacierzy;
            dgvMacierzA.Visible = true;
            dgvMacierzA.ReadOnly = false;
            dgvMacierzA.AllowUserToAddRows = false;
            dgvMacierzA.ColumnHeadersHeightSizeMode = 
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMacierzA.MultiSelect = false;

            //Sformatowanie zawartości nagłówka
            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle();
            StylHeaderKolumny.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderKolumny.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StylHeaderKolumny.Format = "    ";

            dgvMacierzA.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;

            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle();
            StylHeaderWiersza.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderWiersza.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMacierzA.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort i = 0; i < LiczbaKolulmMacierzy; i++)
            {
                dgvMacierzA.Columns[i].HeaderText = "(" + i + ")";
                dgvMacierzA.Columns[i].Width = SzerokoscKolumny;
                dgvMacierzA.Columns[i].DefaultCellStyle.Alignment = 
                    DataGridViewContentAlignment.MiddleCenter;
            }
            for (ushort i = 0; i < LiczbaWierszyMacierzy; i++)
                dgvMacierzA.Rows.Add();

            for (ushort i = 0; i < LiczbaWierszyMacierzy; i++)
                dgvMacierzA.Rows[i].HeaderCell.Value = "(" + i + ")";

            tabControlZakladki.TabPages[1].Controls.Add(dgvMacierzA);

            dgvMacierzA.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMacierzA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnGenerujElementyMacierzyA.Enabled = true;
            btnAkceptacjaWarMacierzaA.Enabled = true;
            btnUtworzkontrolkęDataGridviewMacierzyB.Enabled = true;

            btnUtworzKontrolkeA.Enabled = false;
            txtLiczbaKolumn.Enabled = false;
            txtLiczbaWierszy.Enabled = false;
        }

        private void btnGenerujElementyMacierzyA_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (ushort i = 0; i < dgvMacierzA.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzA.Columns.Count; j++)
                {
                    dgvMacierzA.Rows[i].Cells[j].Value = rnd.Next(DolnaGranicaPrzedzialu, GornaGranicaPrzedzialu);
                }
            btnGenerujElementyMacierzyA.Enabled = false;
        }

        private void btnAkceptacjaWarMacierzaA_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            for (ushort i = 0; i < dgvMacierzA.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzA.Columns.Count; j++)
                {
                    if (dgvMacierzA.Rows[i].Cells[j].Value is null)
                    {
                        errorProvider1.SetError(txtLiczbaWierszy, "ERROR: Niektóre komórki macierzy A są puste");
                        return;
                    }
                }
            dgvMacierzA.ReadOnly = true;
            btnAkceptacjaWarMacierzaA.Enabled = false;
            if (btnAkceptacjaWarMacierzaB.Enabled == false 
                && btnAkceptacjaWarMacierzaB.Enabled == false 
                && btnGenerujElementyMacierzyB.Enabled == false)
            {
                //Aktyacja przycisków do obliczeń na macierzach
                btnSumaMacierzyAiB.Enabled = true;
                btnRoznicaAiB.Enabled = true;
                btnRoznicaBiA.Enabled = true;
                btnIloczynMacierzyAiB.Enabled = true;

            }
        }

        private void btnSumaMacierzyAiB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            if (btnAkceptacjaWarMacierzaA.Enabled || btnAkceptacjaWarMacierzaB.Enabled)
            {
                errorProvider1.SetError(btnSumaMacierzyAiB, "ERROR: Brak zaakceptowania obu macierzy");
                return;
            }
            if (dgvMacierzC is null)
            {
                UtworzKontrolkeDgvDlaMacierzyC();
            }
            A = new Macierz((ushort)dgvMacierzA.Rows.Count, (ushort)dgvMacierzA.Columns.Count);
            B = new Macierz((ushort)dgvMacierzB.Rows.Count, (ushort)dgvMacierzB.Columns.Count);
            C = new Macierz((ushort)dgvMacierzC.Rows.Count, (ushort)dgvMacierzC.Columns.Count);

            A.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzA);
            B.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzB);

            C = A + B;
            C.PrzepiszElementyMacierzyDoKontrolkiDataGridView(dgvMacierzC);

            btnSumaMacierzyAiB.Enabled = false;
        }

        public void UtworzKontrolkeDgvDlaMacierzyC()
        {
            ushort liczbaWierszy, liczbaKolumn;

            errorProvider1.Dispose();

            if (!ushort.TryParse(txtLiczbaWierszy.Text, out liczbaWierszy))
            {
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: Niedozwolona wartość (tylko liczby naturalne)");
                return;
            }
            if (!ushort.TryParse(txtLiczbaKolumn.Text, out liczbaKolumn))
            {
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: Niedozwolona wartość (tylko liczby naturalne)");
                return;
            }

            //Właściwości dgvMacierzC
            dgvMacierzC = new DataGridView();

            ushort odstep = 10;
            ushort SzerokoscKolumny = 70;
            ushort WysokoscWiersza = 25;

            //Lokalizacja
            dgvMacierzC.Location = new Point(groupBox3.Location.X + groupBox3.Width + odstep,
                dgvMacierzB.Location.Y + dgvMacierzB.Height + odstep);

            //Rozmiar
            dgvMacierzC.Size = new Size((IloscKolumn(liczbaKolumn) + 1) * SzerokoscKolumny,
                (IloscWierszy(liczbaWierszy) + 1) * WysokoscWiersza);

            dgvMacierzC.ColumnCount = liczbaKolumn;

            dgvMacierzC.ColumnHeadersVisible = true;
            dgvMacierzC.ReadOnly = false;
            dgvMacierzC.AllowUserToAddRows = false;
            dgvMacierzC.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMacierzC.MultiSelect = false;

            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle();
            StylHeaderKolumny.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderKolumny.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StylHeaderKolumny.Format = "    ";

            dgvMacierzC.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;

            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle();
            StylHeaderWiersza.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderWiersza.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMacierzC.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort i = 0; i < liczbaKolumn; i++)
            {
                dgvMacierzC.Columns[i].HeaderText = "(" + i + ")";
                dgvMacierzC.Columns[i].Width = SzerokoscKolumny;
                dgvMacierzC.Columns[i].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            for (ushort i = 0; i < liczbaWierszy; i++)
                dgvMacierzC.Rows.Add();

            for (ushort i = 0; i < liczbaWierszy; i++)
            {
                dgvMacierzC.Rows[i].HeaderCell.Value = "(" + i + ")";
                dgvMacierzC.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            tabControlZakladki.TabPages[1].Controls.Add(dgvMacierzC);

            dgvMacierzC.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //dgvMacierzC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private ushort IloscWierszy(ushort liczbaWierszy)
        {
            if (liczbaWierszy > 6)
            {
                return 6;
            }

            return liczbaWierszy;
        }

        private ushort IloscKolumn(ushort liczbaKolumn)
        {
            if (liczbaKolumn > 6)
            {
                return 6;
            }

            return liczbaKolumn;
        }

        private void btnUtworzkontrolkęDataGridviewMacierzyB_Click(object sender, EventArgs e)
        {
            ushort Odstep = 10;
            ushort SzerokoscKolumny = 70;
            ushort WysokoscWiersza = 25;
            ushort LiczbaWierszyMacierzy;
            ushort LiczbaKolulmMacierzy;

            errorProvider1.Dispose();

            if (!ushort.TryParse(txtLiczbaWierszy.Text, out LiczbaWierszyMacierzy))
            {
                errorProvider1.SetError(txtLiczbaWierszy, "ERROR: Niedozwolona wartość (tylko liczby naturalne)");
                return;
            }
            if (!ushort.TryParse(txtLiczbaKolumn.Text, out LiczbaKolulmMacierzy))
            {
                errorProvider1.SetError(txtLiczbaKolumn, "ERROR: Niedozwolona wartość (tylko liczby naturalne)");
                return;
            }
            //Właściwości dgvMacierzA
            dgvMacierzB = new DataGridView();

            //Lokalizacja
            dgvMacierzB.Location = new Point(groupBox1.Location.X + groupBox1.Width + Odstep,
                dgvMacierzA.Location.Y + dgvMacierzA.Height + Odstep);

            //Rozmiar
            dgvMacierzB.Size = new Size((LiczbaKolulmMacierzy + 1) * SzerokoscKolumny,
                (LiczbaWierszyMacierzy + 1) * WysokoscWiersza);

            dgvMacierzB.ColumnCount = LiczbaKolulmMacierzy;
            dgvMacierzB.Visible = true;
            dgvMacierzB.ReadOnly = false;
            dgvMacierzB.AllowUserToAddRows = false;
            dgvMacierzB.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMacierzA.MultiSelect = false;

            //Sformatowanie zawartości nagłówka
            DataGridViewCellStyle StylHeaderKolumny = new DataGridViewCellStyle();
            StylHeaderKolumny.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderKolumny.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StylHeaderKolumny.Format = "    ";

            dgvMacierzB.ColumnHeadersDefaultCellStyle = StylHeaderKolumny;

            DataGridViewCellStyle StylHeaderWiersza = new DataGridViewCellStyle();
            StylHeaderWiersza.Font = new Font("Arial", 10, FontStyle.Bold);
            StylHeaderWiersza.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMacierzB.RowHeadersDefaultCellStyle = StylHeaderWiersza;

            for (ushort i = 0; i < LiczbaKolulmMacierzy; i++)
            {
                dgvMacierzB.Columns[i].HeaderText = "(" + i + ")";
                dgvMacierzB.Columns[i].Width = SzerokoscKolumny;
                dgvMacierzB.Columns[i].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            for (ushort i = 0; i < LiczbaWierszyMacierzy; i++)
                dgvMacierzB.Rows.Add();

            for (ushort i = 0; i < LiczbaWierszyMacierzy; i++)
                dgvMacierzB.Rows[i].HeaderCell.Value = "(" + i + ")";

            tabControlZakladki.TabPages[1].Controls.Add(dgvMacierzB);

            dgvMacierzB.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMacierzB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnGenerujElementyMacierzyB.Enabled = true;
            btnAkceptacjaWarMacierzaB.Enabled = true;

            btnUtworzkontrolkęDataGridviewMacierzyB.Enabled = false;

        }

        private void btnGenerujElementyMacierzyB_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (ushort i = 0; i < dgvMacierzB.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzB.Columns.Count; j++)
                {
                    dgvMacierzB.Rows[i].Cells[j].Value = rnd.Next(DolnaGranicaPrzedzialu, GornaGranicaPrzedzialu);
                }
            btnGenerujElementyMacierzyB.Enabled = false;
        }

        private void btnAkceptacjaWarMacierzaB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            for (ushort i = 0; i < dgvMacierzB.Rows.Count; i++)
                for (ushort j = 0; j < dgvMacierzB.Columns.Count; j++)
                {
                    if (dgvMacierzB.Rows[i].Cells[j].Value is null)
                    {
                        errorProvider1.SetError(txtLiczbaWierszy, "ERROR: Niektóre komórki macierzy A są puste");
                        return;
                    }
                }
                dgvMacierzB.ReadOnly = true;
            btnAkceptacjaWarMacierzaB.Enabled = false;
        }

        private void btnRoznicaAiB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            if (btnAkceptacjaWarMacierzaA.Enabled || btnAkceptacjaWarMacierzaB.Enabled)
            {
                errorProvider1.SetError(btnSumaMacierzyAiB, "ERROR: Brak zaakceptowania obu macierzy");
                return;
            }
            if (dgvMacierzC is null)
            {
                UtworzKontrolkeDgvDlaMacierzyC();
            }
            A = new Macierz((ushort)dgvMacierzA.Rows.Count, (ushort)dgvMacierzA.Columns.Count);
            B = new Macierz((ushort)dgvMacierzB.Rows.Count, (ushort)dgvMacierzB.Columns.Count);
            C = new Macierz((ushort)dgvMacierzC.Rows.Count, (ushort)dgvMacierzC.Columns.Count);

            A.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzA);
            B.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzB);

            C = A - B;
            C.PrzepiszElementyMacierzyDoKontrolkiDataGridView(dgvMacierzC);

            btnRoznicaAiB.Enabled = false;
        }

        private void btnRoznicaBiA_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            if (btnAkceptacjaWarMacierzaA.Enabled || btnAkceptacjaWarMacierzaB.Enabled)
            {
                errorProvider1.SetError(btnSumaMacierzyAiB, "ERROR: Brak zaakceptowania obu macierzy");
                return;
            }
            if (dgvMacierzC is null)
            {
                UtworzKontrolkeDgvDlaMacierzyC();
            }
            A = new Macierz((ushort)dgvMacierzA.Rows.Count, (ushort)dgvMacierzA.Columns.Count);
            B = new Macierz((ushort)dgvMacierzB.Rows.Count, (ushort)dgvMacierzB.Columns.Count);
            C = new Macierz((ushort)dgvMacierzC.Rows.Count, (ushort)dgvMacierzC.Columns.Count);

            A.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzA);
            B.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzB);

            C = B - A;
            C.PrzepiszElementyMacierzyDoKontrolkiDataGridView(dgvMacierzC);

            btnRoznicaBiA.Enabled = false;
        }

        private void btnIloczynMacierzyAiB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            if (btnAkceptacjaWarMacierzaA.Enabled || btnAkceptacjaWarMacierzaB.Enabled)
            {
                errorProvider1.SetError(btnSumaMacierzyAiB, "ERROR: Brak zaakceptowania obu macierzy");
                return;
            }
            if (dgvMacierzA.Rows.Count != dgvMacierzA.ColumnCount)
            {
                errorProvider1.SetError(btnIloczynMacierzyAiB, "ERROR: mnożyć można macierze o tej samej liczbie wierszy i lkolumn");
                return;
            }
            if (dgvMacierzC is null)
            {
                UtworzKontrolkeDgvDlaMacierzyC();
            }
            A = new Macierz((ushort)dgvMacierzA.Rows.Count, (ushort)dgvMacierzA.Columns.Count);
            B = new Macierz((ushort)dgvMacierzB.Rows.Count, (ushort)dgvMacierzB.Columns.Count);
            C = new Macierz((ushort)dgvMacierzC.Rows.Count, (ushort)dgvMacierzC.Columns.Count);

            A.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzA);
            B.PrzepiszElementyDataGridViewDoMacierzy(dgvMacierzB);

            C = A * B;
            C.PrzepiszElementyMacierzyDoKontrolkiDataGridView(dgvMacierzC);

            btnIloczynMacierzyAiB.Enabled = false;
        }

        private void btnSumaAiB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            double czRecz, czUr;
            if (!double.TryParse(txtCzescRzeczywistaA.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaA, "Error: To nie liczba");
            }
            if (!double.TryParse(txtCzescUrojonaA.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaA, "Error: To nie liczba");
            }

            zA = new Zespolona(czRecz, czUr);

            if (!double.TryParse(txtCzescRzeczywistaB.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaB, "Error: To nie liczba");
            }
            if (!double.TryParse(txtCzescUrojonaB.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaB, "Error: To nie liczba");
            }

            zB = new Zespolona(czRecz, czUr);

            zC = zA + zB;

            txtWynik.Text = zC.WyswietlWynik(zC);

            //kontrolki
            txtCzescRzeczywistaA.Enabled = false;
            txtCzescUrojonaA.Enabled = false;
            txtCzescRzeczywistaB.Enabled = false;
            txtCzescUrojonaB.Enabled = false;
            btnSumaAiB.Enabled = false;
        }

        private void btnRoznicaAB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            double czRecz, czUr;
            if (!double.TryParse(txtCzescRzeczywistaA.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaA, "Error: To nie liczba");
                return;
            }
            if (!double.TryParse(txtCzescUrojonaA.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaA, "Error: To nie liczba");
                return;
            }

            zA = new Zespolona(czRecz, czUr);

            if (!double.TryParse(txtCzescRzeczywistaB.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaB, "Error: To nie liczba");
                return;
            }
            if (!double.TryParse(txtCzescUrojonaB.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaB, "Error: To nie liczba");
                return;
            }

            zB = new Zespolona(czRecz, czUr);

            zC = zA - zB;

            txtWynik.Text = zC.WyswietlWynik(zC);

            //kontrolki
            txtCzescRzeczywistaA.Enabled = false;
            txtCzescUrojonaA.Enabled = false;
            txtCzescRzeczywistaB.Enabled = false;
            txtCzescUrojonaB.Enabled = false;
            btnRoznicaAB.Enabled = false;
        }

        private void btnIloczynAiB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            double czRecz, czUr;
            if (!double.TryParse(txtCzescRzeczywistaA.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaA, "Error: To nie liczba");
                return;
            }
            if (!double.TryParse(txtCzescUrojonaA.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaA, "Error: To nie liczba");
                return;
            }

            zA = new Zespolona(czRecz, czUr);

            if (!double.TryParse(txtCzescRzeczywistaB.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaB, "Error: To nie liczba");
                return;
            }
            if (!double.TryParse(txtCzescUrojonaB.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaB, "Error: To nie liczba");
                return;
            }

            zB = new Zespolona(czRecz, czUr);

            zC = zA * zB;

            txtWynik.Text = zC.WyswietlWynik(zC);

            //kontrolki
            txtCzescRzeczywistaA.Enabled = false;
            txtCzescUrojonaA.Enabled = false;
            txtCzescRzeczywistaB.Enabled = false;
            txtCzescUrojonaB.Enabled = false;

            btnIloczynAiB.Enabled = false;
        }

        private void btnIlorazAiB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            double czRecz, czUr;
            if (!double.TryParse(txtCzescRzeczywistaA.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaA, "Error: To nie liczba");
                return;
            }
            if (!double.TryParse(txtCzescUrojonaA.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaA, "Error: To nie liczba");
                return;
            }

            zA = new Zespolona(czRecz, czUr);

            if (!double.TryParse(txtCzescRzeczywistaB.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaB, "Error: To nie liczba");
                return;
            }
            if (!double.TryParse(txtCzescUrojonaB.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaB, "Error: To nie liczba");
                return;
            }

            zB = new Zespolona(czRecz, czUr);

            zC = zA / zB;

            txtWynik.Text = zC.WyswietlWynik(zC);

            //kontrolki
            txtCzescRzeczywistaA.Enabled = false;
            txtCzescUrojonaA.Enabled = false;
            txtCzescRzeczywistaB.Enabled = false;
            txtCzescUrojonaB.Enabled = false;

            btnIloczynAiB.Enabled = false;
        }

        private void btnZToMinusA_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            double czRecz, czUr;
            if (!double.TryParse(txtCzescRzeczywistaA.Text, out czRecz))
            {
                errorProvider1.SetError(txtCzescRzeczywistaA, "Error: To nie liczba");
                return;
            }
            if (!double.TryParse(txtCzescUrojonaA.Text, out czUr))
            {
                errorProvider1.SetError(txtCzescUrojonaA, "Error: To nie liczba");
                return;
            }

            zA = new Zespolona(czRecz, czUr);
            zZ = new Zespolona(zA.czRzeczywista * -1, zA.czUrojona * -1);
            txtWynik.Text = zZ.WyswietlWynik(zZ);

            //kontrolki
            txtCzescRzeczywistaA.Enabled = false;
            txtCzescUrojonaA.Enabled = false;
            txtCzescRzeczywistaB.Enabled = false;
            txtCzescUrojonaB.Enabled = false;

            btnZToMinusA.Enabled = false;
        }
    }
    static class RozszerzenieWlasciwosciKlasyMacierz
    {
        public static void PrzepiszElementyDataGridViewDoMacierzy(this Macierz X, DataGridView dgvMacierzX)
        {
            for (ushort i = 0; i < X.LiczbaWierszy; i++)
                for (ushort j = 0; j < X.LiczbaKolumn; j++)
                    X[i, j] = float.Parse((dgvMacierzX.Rows[i].Cells[j].Value).ToString());
        }
        public static void PrzepiszElementyMacierzyDoKontrolkiDataGridView(this Macierz X, DataGridView dgvMacierzX)
        {
            for (ushort i = 0; i < X.LiczbaWierszy; i++)
                for (ushort j = 0; j < X.LiczbaKolumn; j++)
                    dgvMacierzX.Rows[i].Cells[j].Value = string.Format("{0:F2}", X[i, j]);
        }
    }
}
