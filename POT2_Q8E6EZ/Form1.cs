using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace POT2_Q8E6EZ
{
    public partial class Form1 : Form
    {
        BindingList<KavezoAdat> adatok = new();
        public Form1()
        {
            InitializeComponent();
            kavezoAdatBindingSource.DataSource = adatok;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader("kavezo.txt");
                var csv = new CsvReader(streamReader, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<KavezoAdat>();
                foreach (var item in t)
                {
                    adatok.Add(item);
                }
                streamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(adatok);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (kavezoAdatBindingSource.Current == null) return;
            if (MessageBox.Show("Biztos szeretné törölni az adott sor adatait?", "Törlés megerõsítése", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kavezoAdatBindingSource.RemoveCurrent();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormNew formNew = new FormNew();
            if (formNew.ShowDialog() == DialogResult.OK)
            {
                kavezoAdatBindingSource.Add(formNew.NewKA);
            }
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            double minimum = double.PositiveInfinity;
            string legalacsonyabb = string.Empty;
            int darab = 0;
            int latogatott = 0;
            double ossz = 0;
            int db =0;
            foreach (var item in adatok)
            {
                ossz += item.ProfitEZREuro;
            }
            foreach (var item in adatok)
            {
                if (item.ProfitEZREuro<minimum)
                {
                    minimum = item.ProfitEZREuro;
                    legalacsonyabb = item.Nev;
                }
                if (item.ProfitEZREuro > ossz/adatok.Count())
                {
                    latogatott += item.NapiLatogatok;
                    db++;
                }
            }
            foreach (var item in adatok)
            {
                if (item.Nev==legalacsonyabb)
                {
                    darab++;
                }
            }
            double atlag = latogatott / db;
            MessageBox.Show($"A {legalacsonyabb} kávézónak van a legalacsonyabb profitja. Összesen {darab} darab kávézójuk van. Azoknak a kávézóknak. amiknek a profitja meghaladja az átlagos profitot, {atlag} az átlagos látogatottsága.");
        }
    }
}