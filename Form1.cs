using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RunSpeeed
{

    public partial class Form1 : Form
    {
        public Form1()
    {
        InitializeComponent();
        
    }

        public static bool flag;
    public class HelpingFunctions
    {
        public static double IsValidValue(string trueX, double[] sampleX, double vvalue)
        {
            if ((trueX=="Скользко" || trueX=="Очень маленькие" || trueX == "Молодой" || trueX=="Любитель" || trueX=="Мало") && sampleX[1] > 0.1)
            {
                return vvalue;
            }else if ((trueX == "Среднее" || trueX == "Средние" || trueX == "Среднего возраста" || trueX == "Специалист" || trueX == "Нормально") && sampleX[2] > 0.1)
            {
                return vvalue;
            }else if ((trueX == "Хорошее" || trueX == "Длинные" || trueX == "Пожилой" || trueX == "Профессионал" || trueX == "Много") && sampleX[3] > 0.1)
            {
                return vvalue;
            }
            return 0.01;
        }
    
    
    
    }


    


    
        

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rules> MassWithRules = new List<Rules>(0);
            
            for(int i = 0; i < 60; i++)
            {
                MassWithRules.Add(new Rules());
                MassWithRules[i].flagg = checkBox1.Checked;

            }


            MassWithRules[0].GetRules("Скользко", "Очень маленькие", "Молодой", "Любитель", "Мало", "Маленькая");
            MassWithRules[1].GetRules("Среднее", "Средние", "Молодой", "Любитель", "Нормально", "Средняя");
            MassWithRules[2].GetRules("Скользко", "Средние", "Среднего возраста", "Любитель", "Нормально", "Маленькая");
            MassWithRules[3].GetRules("Скользко", "Очень маленькие", "Пожилой", "Специалист", "Мало", "Маленькая");
            MassWithRules[4].GetRules("Хорошее", "Длинные", "Среднего возраста", "Специалист", "Много", "Большая");
            MassWithRules[5].GetRules("Скользко", "Длинные", "Молодой", "Специалист", "Нормально", "Средняя");
            MassWithRules[6].GetRules("Скользко", "Средние", "Среднего возраста", "Профессионал", "Много", "Большая");
            MassWithRules[7].GetRules("Скользко", "Длинные", "Молодой", "Специалист", "Много", "Большая");
            MassWithRules[8].GetRules("Среднее", "Очень маленькие", "Молодой", "Любитель", "Нормально", "Средняя");
            MassWithRules[9].GetRules("Среднее", "Средние", "Молодой", "Специалист", "Нормально", "Средняя");
            MassWithRules[10].GetRules("Среднее", "Очень маленькие", "Среднего возраста", "Любитель", "Мало", "Маленькая");
            MassWithRules[11].GetRules("Среднее", "Средние", "Молодой", "Любитель", "Мало", "Маленькая");
            MassWithRules[12].GetRules("Скользко", "Средние", "Пожилой", "Любитель", "Нормально", "Маленькая");
            MassWithRules[13].GetRules("Скользко", "Средние", "Пожилой", "Профессионал", "Много", "Средняя");
            MassWithRules[14].GetRules("Среднее", "Очень маленькие", "Молодой", "Любитель", "Мало", "Маленькая");
            MassWithRules[15].GetRules("Хорошее", "Очень маленькие", "Молодой", "Любитель", "Мало", "Маленькая");
            MassWithRules[16].GetRules("Среднее", "Средние", "Среднего возраста", "Специалист", "Нормально", "Средняя");
            MassWithRules[17].GetRules("Хорошее", "Длинные", "Пожилой", "Профессионал", "Много", "Большая");
            MassWithRules[18].GetRules("Среднее", "Средние", "Пожилой", "Любитель", "Мало", "Маленькая");
            MassWithRules[19].GetRules("Среднее", "Средние", "Пожилой", "Специалист", "Нормально", "Средняя");
            MassWithRules[20].GetRules("Скользко", "Длинные", "Молодой", "Любитель", "Много", "Средняя");
            MassWithRules[21].GetRules("Среднее", "Средние", "Молодой", "Любитель", "Нормально", "Средняя");
            MassWithRules[22].GetRules("Хорошее", "Длинные", "Среднего возраста", "Любитель", "Мало", "Средняя");
            MassWithRules[23].GetRules("Хорошее", "Средние", "Среднего возраста", "Любитель", "Мало", "Маленькая");
            MassWithRules[24].GetRules("Хорошее", "Средние", "Молодой", "Профессионал", "Нормально", "Большая");
            MassWithRules[25].GetRules("Хорошее", "Средние", "Молодой", "Специалист", "Нормально", "Большая");
            MassWithRules[26].GetRules("Скользко", "Очень маленькие", "Молодой", "Профессионал", "Мало", "Средняя");
            MassWithRules[27].GetRules("Скользко", "Очень маленькие", "Среднего возраста", "Специалист", "Много", "Средняя");
            MassWithRules[28].GetRules("Хорошее", "Очень маленькие", "Среднего возраста", "Профессионал", "Много", "Большая");
            MassWithRules[29].GetRules("Среднее", "Средние", "Молодой", "Профессионал", "Мало", "Средняя");
            MassWithRules[30].GetRules("Скользко", "Средние", "Молодой", "Любитель", "Мало", "Маленькая");
            MassWithRules[31].GetRules("Среднее", "Длинные", "Молодой", "Любитель", "Нормально", "Средняя");
            MassWithRules[32].GetRules("Скользко", "Средние", "Пожилой", "Специалист", "Нормально", "Маленькая");
            MassWithRules[33].GetRules("Скользко", "Средние", "Пожилой", "Специалист", "Мало", "Маленькая");
            MassWithRules[34].GetRules("Хорошее", "Длинные", "Среднего возраста", "Профессионал", "Много", "Большая");
            MassWithRules[35].GetRules("Скользко", "Средние", "Молодой", "Специалист", "Нормально", "Средняя");
            MassWithRules[36].GetRules("Среднее", "Средние", "Среднего возраста", "Специалист", "Много", "Большая");
            MassWithRules[37].GetRules("Скользко", "Нормальные", "Молодой", "Специалист", "Нормально", "Большая");
            MassWithRules[38].GetRules("Среднее", "Средние", "Среднего возраста", "Любитель", "Нормально", "Средняя");
            MassWithRules[39].GetRules("Среднее", "Средние", "Молодой", "Специалист", "Много", "Средняя");
            MassWithRules[40].GetRules("Среднее", "Очень маленькие", "Среднего возраста", "Любитель", "Нормально", "Маленькая");
            MassWithRules[41].GetRules("Среднее", "Средние", "Пожилой", "Специалист", "Мало", "Маленькая");
            MassWithRules[42].GetRules("Среднее", "Средние", "Пожилой", "Любитель", "Нормально", "Маленькая");
            MassWithRules[43].GetRules("Скользко", "Средние", "Пожилой", "Профессионал", "Нормально", "Средняя");
            MassWithRules[44].GetRules("Среднее", "Очень маленькие", "Молодой", "Специалист", "Мало", "Маленькая");
            MassWithRules[45].GetRules("Хорошее", "Очень маленькие", "Молодой", "Любитель", "Нормально", "Средняя");
            MassWithRules[46].GetRules("Среднее", "Средние", "Среднего возраста", "Профессионал", "Нормально", "Большая");
            MassWithRules[47].GetRules("Хорошее", "Длинные", "Молодой", "Специалист", "Много", "Большая");
            MassWithRules[48].GetRules("Хорошее", "Средние", "Пожилой", "Любитель", "Мало", "Маленькая");
            MassWithRules[49].GetRules("Среднее", "Длинные", "Пожилой", "Любитель", "Мало", "Средняя");
            MassWithRules[50].GetRules("Скользко", "Длинные", "Молодой", "Профессионал", "Много", "Большая");
            MassWithRules[51].GetRules("Среднее", "Средние", "Среднего возраста", "Любитель", "Много", "Средняя");
            MassWithRules[52].GetRules("Хорошее", "Длинные", "Пожилой", "Любитель", "Мало", "Средняя");
            MassWithRules[53].GetRules("Хорошее", "Очень маленькие", "Среднего возраста", "Любитель", "Мало", "Маленькая");
            MassWithRules[54].GetRules("Хорошее", "Средние", "Молодой", "Профессионал", "Много", "Большая");
            MassWithRules[55].GetRules("Хорошее", "Средние", "Среднего возраста", "Специалист", "Нормально", "Большая");
            MassWithRules[56].GetRules("Скользко", "Очень маленькие", "Молодой", "Профессионал", "Нормально", "Средняя");
            MassWithRules[57].GetRules("Скользко", "Очень маленькие", "Среднего возраста", "Специалист", "Нормально", "Средняя");
            MassWithRules[58].GetRules("Хорошее", "Очень маленькие", "Среднего возраста", "Профессионал", "Нормально", "Большая");
            MassWithRules[59].GetRules("Скользко", "Средние", "Молодой", "Профессионал", "Много", "Средняя");








            double[] TrenieAga = new double[4];
            double[] DlinaNogAga = new double[4];
            double[] VozrastAga = new double[4];
            double[] StajAga = new double[4];
            double[] PrisedanAga = new double[4];
            
            double buffZnam = 0;
            double buffChisl = 0;
            double Finally = 0;

            if (checkBox1.Checked)
            {
                TrenieAga = TrapTrenie(Convert.ToDouble(Convert.ToInt32(textBox1.Text)));
                DlinaNogAga = TrapDlinaNog(Convert.ToDouble(Convert.ToInt32(textBox2.Text)));
                VozrastAga = TrapVozrast(Convert.ToDouble(Convert.ToInt32(textBox3.Text)));
                StajAga = TrapStajTren(Convert.ToDouble(Convert.ToInt32(textBox4.Text)));
                PrisedanAga = TrapPrisedan(Convert.ToDouble(Convert.ToInt32(textBox5.Text)));
                flag = true;

            }
            else
            {
                TrenieAga = TriangTrenie(Convert.ToDouble(Convert.ToInt32(textBox1.Text)));
                DlinaNogAga = TriangDlinaNog(Convert.ToDouble(Convert.ToInt32(textBox2.Text)));
                VozrastAga = TriangVozrast(Convert.ToDouble(Convert.ToInt32(textBox3.Text)));
                StajAga = TriangStajTren(Convert.ToDouble(Convert.ToInt32(textBox4.Text)));
                PrisedanAga = TriangPrisedan(Convert.ToDouble(Convert.ToInt32(textBox5.Text)));
                flag = false;
            }

           


            for (int i = 0; i < 60; i++)
            {
                MassWithRules[i].UpdateRule(HelpingFunctions.IsValidValue(MassWithRules[i].RuleLang[0], TrenieAga, TrenieAga[0]), HelpingFunctions.IsValidValue(MassWithRules[i].RuleLang[1], DlinaNogAga, DlinaNogAga[0]), HelpingFunctions.IsValidValue(MassWithRules[i].RuleLang[2], VozrastAga, VozrastAga[0]), HelpingFunctions.IsValidValue(MassWithRules[i].RuleLang[3], StajAga, StajAga[0]), HelpingFunctions.IsValidValue(MassWithRules[i].RuleLang[4], PrisedanAga, PrisedanAga[0]));
                buffZnam += MassWithRules[i].Alpha[0];
                buffChisl += MassWithRules[i].Alpha[1];
            }
            Finally = buffChisl / buffZnam;
            label9.Text = Convert.ToString(Finally) + " м/c";


        }

        
        //Функции трапеции для входных переменных
        public static double[] TrapTrenie(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;
            if (x > 30 && x < 50)
            {
                if (((40 - x) / 10) > ((x - 30) / 20))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((40 - x) / 10);
                }
                else { buffdbl[2] = 1; buffdbl[0] = ((x - 30) / 20); }

            }
            else if (x > 70 && x < 90)
            {
                if(((80 - x) / 10)> ((x - 75) / 15))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((80 - x) / 10);

                }else { buffdbl[3] =1; buffdbl[0] = ((x - 75) / 15); }
            }
            else if (x <= 30)
            {
                buffdbl[1] = 1;buffdbl[0] = 100.0;
            }
            else if (x <= 70)
            {
                buffdbl[2] = 1;buffdbl[0] = 100;
            }
            else
            {
                buffdbl[3] = 1;buffdbl[0] = 100;
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }
        public static double[] TrapVozrast(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            if (x > 20 && x < 40)
            {
                if (((30 - x) / 10) > ((x - 25) / 15))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((30 - x) / 10);
                }
                else { buffdbl[2] = 1; buffdbl[0] = ((x - 25) / 15); }

            }
            else if (x > 50 && x < 65)
            {
                if (((60 - x) / 10) > ((x - 55) / 10))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((60 - x) / 10);

                }
                else { buffdbl[3] = 1; buffdbl[0] = ((x - 55) / 10); }
            }
            else if (x <= 20)
            {
                buffdbl[1] = 1; buffdbl[0] = 100;
            }
            else if (x <= 50)
            {
                buffdbl[2] = 1; buffdbl[0] = 100;
            }
            else
            {
                buffdbl[3] = 1; buffdbl[0] = 100;
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        public static double[] TrapDlinaNog(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            double normalx = ((x - 120) / 120)*100;


            
            if (normalx > 15 && normalx < 50)
            {
                if (((25 - normalx) / 10) > ((normalx - 20) / 30))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((25 - normalx) / 10);
                }
                else { buffdbl[2] = 1; buffdbl[0] = ((normalx - 20) / 30); }

            }
            else if (normalx > 65 && normalx < 85)
            {
                if (((80 - normalx) / 15) > ((normalx - 70) / 15))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((80 - normalx) / 15);

                }
                else { buffdbl[3] = 1; buffdbl[0] = ((normalx - 70) / 15); }
            }
            else if (normalx <= 15)
            {
                buffdbl[1] = 1; buffdbl[0] = 100;
            }
            else if (normalx <= 65)
            {
                buffdbl[2] = 1; buffdbl[0] = 100;
            }
            else
            {
                buffdbl[3] = 1; buffdbl[0] = 100;
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        public static double[] TrapPrisedan(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            double normalx = ((x - 300) / 300) * 100;



            if (normalx > 15 && normalx < 40)
            {
                if (((30 - normalx) / 15) > ((normalx - 20) / 20))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((30 - normalx) / 15);
                }
                else { buffdbl[2] = 1; buffdbl[0] = ((normalx - 20) / 20); }

            }
            else if (normalx > 60 && normalx < 80)
            {
                if (((70 - normalx) / 10) > ((normalx - 65) / 15))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((70 - normalx) / 10);

                }
                else { buffdbl[3] = 1; buffdbl[0] = ((normalx - 65) / 15); }
            }
            else if (normalx <= 15)
            {
                buffdbl[1] = 1; buffdbl[0] = 100;
            }
            else if (normalx <= 60)
            {
                buffdbl[2] = 1; buffdbl[0] = 100;
            }
            else
            {
                buffdbl[3] = 1; buffdbl[0] = 100;
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        public static double[] TrapStajTren(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            double normalx = ((x - 20) / 20) * 100;



            if (normalx > 20 && normalx < 40)
            {
                if (((30 - normalx) / 10) > ((normalx - 25) / 15))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((30 - normalx) / 10);
                }
                else { buffdbl[2] = 1; buffdbl[0] = ((normalx - 25) / 15); }

            }
            else if (normalx > 55 && normalx < 80)
            {
                if (((75 - normalx) / 20) > ((normalx - 65) / 15))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((75 - normalx) / 20);

                }
                else { buffdbl[3] = 1; buffdbl[0] = ((normalx - 65) / 15); }
            }
            else if (normalx <= 20)
            {
                buffdbl[1] = 1; buffdbl[0] = 100;
            }
            else if (normalx <= 55)
            {
                buffdbl[2] = 1; buffdbl[0] = 100;
            }
            else
            {
                buffdbl[3] = 1; buffdbl[0] = 100;
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }
        //Функции треугольника для входных переменных
        public static double[] TriangTrenie(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            if (x < 60)
            {
                if(((40-x)/40) > ((x - 30) / 30))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((40 - x) / 40);

                }
                else
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((x - 30) / 30);
                }
            }else
            {
                if(((80-x)/20)> ((x-75)/25)) 
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((80 - x) / 20);
                }
                else
                {
                    buffdbl[3] = 1;
                    buffdbl[0] = ((x - 75) / 25);
                }
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        public static double[] TriangVozrast(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            if (x < 45)
            {
                if (((30 - x) / 30) > ((x - 25) / 20))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((30 - x) / 30);

                }
                else
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((x - 25) / 20);
                }
            }
            else
            {
                if (((60 - x) / 15) > ((x - 55) / 45))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((60 - x) / 15);
                }
                else
                {
                    buffdbl[3] = 1;
                    buffdbl[0] = ((x - 55) / 45);
                }
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        public static double[] TriangDlinaNog(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            double normalx = ((x - 120) / 120) * 100;

            if (normalx < 57.5)
            {
                if (((25 - normalx) / 25) > ((normalx - 20) / 37.5))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((30 - normalx) / 30);

                }
                else
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((normalx - 20) / 37.5);
                }
            }
            else
            {
                if (((80 - normalx) / 22.5) > ((normalx - 70) / 30))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((80 - normalx) / 22.5);
                }
                else
                {
                    buffdbl[3] = 1;
                    buffdbl[0] = ((normalx - 70) / 30);
                }
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        public static double[] TriangPrisedan(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            double normalx = ((x - 300) / 300) * 100;

            if (normalx < 50)
            {
                if (((30 - normalx) / 30) > ((normalx - 20) / 30))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((30 - normalx) / 30);

                }
                else
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((normalx - 20) / 30);
                }
            }
            else
            {
                if (((70 - normalx) / 20) > ((normalx - 65) / 35))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((70 - normalx) / 20);
                }
                else
                {
                    buffdbl[3] = 1;
                    buffdbl[0] = ((normalx - 65) / 35);
                }
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        public static double[] TriangStajTren(double x)
        {
            double[] buffdbl = new double[4];
            buffdbl[1] = 0;
            buffdbl[2] = 0;
            buffdbl[3] = 0;

            double normalx = ((x - 20) / 20) * 100;

            if (normalx < 47.5)
            {
                if (((30 - normalx) / 30) > ((normalx - 25) / 22.5))
                {
                    buffdbl[1] = 1;
                    buffdbl[0] = ((30 - normalx) / 30);

                }
                else
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((normalx - 25) / 22.5);
                }
            }
            else
            {
                if (((75 - normalx) / 27.5) > ((normalx - 65) / 35))
                {
                    buffdbl[2] = 1;
                    buffdbl[0] = ((75 - normalx) / 27.5);
                }
                else
                {
                    buffdbl[3] = 1;
                    buffdbl[0] = ((normalx - 65) / 35);
                }
            }
            buffdbl[0] /= 100;
            return buffdbl;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }


    //Конструктор правил
    public class Rules
    {
        //Правило, словесно
        public string[] RuleLang = new string[6];
        //Правило, числовые значения функций принадлежности
        public double[] RuleNumeric = new double[5];
        //Alpha - первый элемент это i-й член знаменателя, второй - i-й член числителя
        public double[] Alpha = new double[2];

        public bool flagg = true;
        public static double Minimum(double x1, double x2)
        {
            if (x1 > x2) { return x2; } else { return x1; }
        }
        //Вычисление площади(Значение i-го члена в числителе для формулы вычисления центра масс)
        public static double Ploshad(double x, string L)
        {
            double buffDDD;


            
            if (L == "Маленькая")
            {
                buffDDD = (x * 8.75 * x) + (x * (37.5 - x * 17.5));
            }
            else if (L == "Средняя")
            {
                buffDDD = (x * (50 - x * 30)) + (x * x * 15);
            }
            else
            {
                buffDDD = (x * x * 5) + ((30 - x * 10) * x);
            }
            buffDDD *= x;
            return buffDDD;
        

        }

        public static double Ploshadtriangle(double x, string L)
        {
            double buffDDD;



            if (L == "Маленькая")
            {
                buffDDD = ((37.5 - x * 37.5) * x) + (x * x * 18.75);
            }
            else if (L == "Средняя")
            {
                buffDDD = (x * x * 25) + ((50 - x * 50) * x);
            }
            else
            {
                buffDDD = (x * 15) + (x * (30 - x * 30));
            }
            buffDDD *= x;
            return buffDDD;


        }

        //Для инициализации конструктора
        public Rules(){
           


        }




        //Запись правила
        public void GetRules(string l0, string l1, string l2, string l3, string l4, string l5)
        {
            this.RuleLang[0] = l0;
            this.RuleLang[1] = l1;
            this.RuleLang[2] = l2;
            this.RuleLang[3] = l3;
            this.RuleLang[4] = l4;
            this.RuleLang[5] = l5;
           
        }

        public void UpdateRule(double x0, double x1, double x2, double x3, double x4)
        {
            this.RuleNumeric[0] = x0;
            this.RuleNumeric[1] = x1;
            this.RuleNumeric[2] = x2;
            this.RuleNumeric[3] = x3;
            this.RuleNumeric[4] = x4;
            this.Alpha[0] = Minimum(x0, Minimum(x1, Minimum(x2, Minimum(x3, x4))));
            if (flagg)
            {
                this.Alpha[1] = Ploshad(Alpha[0], RuleLang[5]);
            }
            else
            {
                this.Alpha[1] = Ploshadtriangle(Alpha[0], RuleLang[5]);
            }
            
        }








    }


}


