namespace ZusApp
{
    public partial class Form1 : Form
    {
        string zarazeni = "";
        int rok;

        public Form1()
        {
            InitializeComponent();
            DateTime datum = DateTime.Now;
            datumText.Text = datum.Date.ToShortDateString();
            rok = datum.Year;
            vysledek.Enabled = false;
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            int vyska = Form1.ActiveForm.ClientSize.Height;
            int sirka = Form1.ActiveForm.ClientSize.Width;

            panel.Location = new Point(sirka / 2 - panel.Width / 2, vyska / 2 - panel.Height / 2);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int vek = 0;
            vek = nactiVek();

            int obor = 0;
            obor = nactiObor();
            vysledek.Enabled = true;
            konec:
            vysledek.Text = urciZarazeni(vek, obor);

        }

        private int nactiVek()
        {
            int vek = 0;

            string datumNarozeni = "";
            datumNarozeni = datumText.Text;

            string[] cisla = { "0", "0", "0" };
            if (datumNarozeni[datumNarozeni.Length - 1] == '.')
            {
                MessageBox.Show("Zadané datum narození je v nesprávném formátu!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cisla[1] = "0";
                cisla[2] = "0";
                goto magor;
            }
            string povoleneZnaky = ".0123456789";
            int y = 0;
            foreach (char c in datumNarozeni)
            {
                if (c == '.') y++;
                int x = 0;
                foreach (char n in povoleneZnaky)
                {
                    if (c == n) x++;
                }
                if (x == 0)
                {
                    MessageBox.Show("Zadané datum narození je v nesprávném formátu!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cisla[1] = "0";
                    cisla[2] = "0";
                    goto magor;
                }

            }
            if (y != 2)
            {
                MessageBox.Show("Zadané datum narození je v nesprávném formátu!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cisla[1] = "0";
                cisla[2] = "0";
                goto magor;
            }

            cisla = datumNarozeni.Split('.');
            magor:

            vek = rok - int.Parse(cisla[2]);
            if (int.Parse(cisla[1]) < 9)
            {
                vek++;
            }

            return vek;
        }

        private int nactiObor()
        {
            int obor = 0;
            if (kolonkaObor.Text.ToString() == "HO")
            {
                obor = 1;
            }
            else
            {
                obor = 2;
            }
            return obor;
        }

        private string urciZarazeni(int vek, int obor)
        {

            switch (obor)
            {
                case 1:

                    if (vek == 5)
                    {
                        pojmenuj("PHV1");
                    }
                    else if (vek == 6)
                    {
                        pojmenuj("PHV2");
                    }
                    else if (vek >= 7 && vek <= 12)
                    {
                        pojmenuj("1/I");
                    }
                    else if (vek == 11)
                    {
                        pojmenuj("2/I");
                    }
                    else if (vek == 13)
                    {
                        pojmenuj("PHV/II");
                    }
                    else if (vek >= 14 && vek <= 17)
                    {
                        pojmenuj("1/II");
                    }
                    else if (vek >= 18)
                    {
                        pojmenuj("SPD");
                    }
                    else
                    {
                        pojmenuj("???");
                    }

                    break;

                case 2:

                    if (vek == 5)
                    {
                        pojmenuj("PVV1");
                    }
                    else if (vek == 6)
                    {
                        pojmenuj("PVV2");
                    }
                    else if (vek == 7)
                    {
                        pojmenuj("1/1");
                    }
                    else if (vek >= 8 && vek <= 12)
                    {
                        pojmenuj("1/I");
                    }
                    else if (vek == 11)
                    {
                        pojmenuj("2/I");
                    }
                    else if (vek == 3)
                    {
                        pojmenuj("PVV/II");
                    }
                    else if (vek >= 14 && vek <= 17)
                    {
                        pojmenuj("1/II");
                    }
                    else if (vek >= 18)
                    {
                        pojmenuj("SPD");
                    }
                    else
                    {
                        pojmenuj("???");
                    }

                    break;

                default:

                    break;

            }
            return zarazeni;
        }

        private void pojmenuj(string text)
        {
            zarazeni = text;
        }

        private void datumText_TextChanged(object sender, EventArgs e)
        {
            vysledek.Enabled = false;
        }

    }
}