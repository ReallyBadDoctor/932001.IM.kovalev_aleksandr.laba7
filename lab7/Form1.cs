using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // преступность и квалификация находятся в пределе от 0 до 1 и являются соотношением параметра к,
        //например, наибольшему параметру по региону (области или стране)
        double crimeL, persqual, budget, payment = 100, rate, utilities = 15, equipment = 5, income;
        double clients_come, clients_out, clients_inside, max_rooms = 1000, room_cost, room_cost_on_start = 20; 
     


        int day; 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int click_count; 
        private void btstart_Click(object sender, EventArgs e)
        {
            click_count++;
            if (click_count % 2 == 1)
            {
                timer1.Stop();
                crimeLevel.Enabled = true;
                persqua.Enabled = true;
                Sbudget.Enabled = true;
                Srate.Enabled = true;
            }
            else
            {
                crimeLevel.Enabled = false;
                persqua.Enabled = false;
                Sbudget.Enabled = false;
                Srate.Enabled = false;
                timer1.Start(); 
            }

        }

        private void btreset_Click(object sender, EventArgs e)
        {
            budg_chart.Series[0].Points.Clear();
            clients_come = 0;
            clients_out = 0;
            clients_inside = 0; 
            click_count = 0; 
            day = 1; 
            crimeL = (double)crimeLevel.Value;
            persqual = (double)persqua.Value;
            budget = (double)Sbudget.Value;
            rate = (double)Srate.Value;
            room_cost = room_cost_on_start * rate;

            crimeLevel.Enabled = false;
            persqua.Enabled = false;
            Sbudget.Enabled = false;
            Srate.Enabled = false;

            timer1.Start(); 
        }

        void clients_changes()
        {
            // клиентов будет приходить больше, если хороший рейтинг, низкая преступность, хорошее обслуживание
            Random rand = new Random();             
            clients_come = (1 + rand.NextDouble() * 200) * (rate / 10) * (1 - crimeL) * persqual;
            // клиентов будет уходить больше, если плохой рейтинг, высокая преступность, плохое обслуживание. 
            clients_out = clients_inside * ((10 - rate)/10 + crimeL + (1 - persqual)) / 3;
            clients_inside += (clients_come - clients_out);
            // максимальное число клиентов может быть не более max_rooms
            if (clients_inside > max_rooms)
            {
                clients_inside = max_rooms;
            }
        }

        void budget_changes()
        {
            // с ростом числа клиентов, увеличиваем персонал и, соответственно, растут затраты на зарплату
            double payment_for_now = payment * persqual * (1 + clients_inside / 10);
            // с ростом числа клиентов растут расходы на коммуналку
            double utilities_for_now = clients_inside * utilities;
            // с ростом числа клиентов расчет доход
            income = clients_inside * room_cost;
            budget += (income - utilities_for_now - payment_for_now); 
        }

        void equipment_changes()
        {
            // стоимость обновления комплектации номеров прямо зависит от нынешней стоимости номера
            double equip_change = equipment * (room_cost / 4);

            // если бюджета для обновления не хватает, мы теряем часть рейтинга
            if (equipment > budget)
            {
                rate = rate - rate / 10;
                room_cost = room_cost_on_start * rate;
            }
            else
            {
                // стоимость улучшения технической оснащенности будет расти вместе со стоимостью комнаты 
                // отдаем 90% бюджета на улучшение технической оснащенности
                double changer = budget * 0.9 / room_cost * 0.001;
                if (rate + changer <= 10)
                {
                    rate += changer;
                    room_cost = room_cost_on_start * rate;
                    budget *= 0.1;
                }
                //если рейтинг уже достиг 10, изменения не происходят 
                else
                {
                    rate = 10;
                    room_cost = room_cost_on_start * rate;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clients_changes();
            budget_changes();
            // каждые 7 дней и в первый день обновляем техническую оснащенность
            if (day % 7 == 0 || day == 1) equipment_changes();
            cli_come.Value = (decimal)clients_come;
            cli_inside.Value = (decimal)clients_inside;
            budget_out.Value = (decimal)budget;
            rate_out.Value = (decimal)rate;
            room_cost_out.Value = (decimal)room_cost;
            cli_out.Value = (decimal)clients_out; 
            Day_out.Value = day;
            budg_chart.Series[0].Points.AddXY(day, Math.Round(income));
            day++;
        }
    }
}
