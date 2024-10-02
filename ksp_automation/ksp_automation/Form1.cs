using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ksp_automation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }


        private void PopulateComboBoxes()
        {
            // Populate Origin and Destination ComboBoxes
            comboBox3.DataSource = KSPData.CelestialBodies.Select(b => b.Name).ToList();
            comboBox4.DataSource = new List<string>(KSPData.CelestialBodies.Select(b => b.Name).ToList());

            // Populate Engine Selection ComboBox
            comboBox5.DataSource = KSPData.Engines.Select(e => e.Name).ToList();

            // Populate Fuel Tank Selection ComboBox
            comboBox6.DataSource = KSPData.FuelTanks.Select(f => f.Name).ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KSPData.CelestialBodies;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = KSPData.Parts;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = KSPData.Engines;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = KSPData.FuelTanks;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string origin = comboBox3.SelectedItem.ToString();
            string destination = comboBox4.SelectedItem.ToString();

            var originBody = KSPData.CelestialBodies.FirstOrDefault(b => b.Name == origin);
            var destBody = KSPData.CelestialBodies.FirstOrDefault(b => b.Name == destination);

            if (originBody != null && destBody != null)
            {
                double deltaV = originBody.EscapeVelocity + destBody.EscapeVelocity;
                textBox2.Text = deltaV.ToString("F2") + " m/s";
            }
            else
            {
                MessageBox.Show("Error: Could not retrieve data for the selected bodies.");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string selectedEngine = comboBox5.SelectedItem.ToString();
            string selectedTank = comboBox6.SelectedItem.ToString();
            double deltaV;

            if (!double.TryParse(textBox2.Text.Replace(" m/s", ""), out deltaV))
            {
                MessageBox.Show("Please calculate Delta-V first.");
                return;
            }

            var engine = KSPData.Engines.FirstOrDefault(e => e.Name == selectedEngine);
            var tank = KSPData.FuelTanks.FirstOrDefault(t => t.Name == selectedTank);

            if (engine != null && tank != null)
            {
                double thrust = (double)engine.ThrustVacuum;
                double isp = engine.IspVacuum;
                double engineMass = (double)engine.Mass;
                double fuelMass = (double)tank.TotalFuelUnits * 0.005; // Assuming 1 fuel unit = 0.005 tons

                double totalMass = engineMass + fuelMass;
                double exhaustVelocity = isp * 9.81; // g0 = 9.81 m/s^2
                double burnTime = (totalMass * exhaustVelocity / thrust) * (1 - Math.Exp(-deltaV / exhaustVelocity));

                textBox3.Text = burnTime.ToString("F2") + " seconds";
            }
            else
            {
                MessageBox.Show("Error: Could not retrieve engine and fuel tank data.");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }



        //SqlConnection connection = new SqlConnection(@"Server=DESKTOP-974N5RH\SQLEXPRESS;Database=KSP;User Id=sa;Password=123;");
    }
}
