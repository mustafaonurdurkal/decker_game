using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanılacak değişkenlerin atanması.
            string cins1, cins2, cins3;
            string no1, no2, no3;
            int puancase1 = 0;
            int puancase2 = 0;
            int puancase3 = 0;
            int puancase4 = 0;
            int puancase5 = 0;
            int puancase6 = 0;
            int puancase7 = 0;
            int puancase8 = 0;

            int puan = 0;
            int num1, num2, num3;
            //Kullanıcıdan kart numaraları ve türlerinin input olarak alınması.

            Console.Write("Enter the suit of first card= ");
            cins1 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the number of first card= ");
            no1 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the suit of second card= ");
            cins2 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the number of second card= ");
            no2 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the suit of third card= ");
            cins3 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the number of third card= ");
            no3 = Convert.ToString(Console.ReadLine());

            //Kullanıcıdan alınan kart türünde büyük küçük harfin dikkate alınmamasını sağladık.
            cins1 = cins1.ToUpper();
            cins2 = cins2.ToUpper();
            cins3 = cins3.ToUpper();

            //Hatalı girişlerin denetlenmesi.
            if (cins1 != "C" && cins1 != "H" && cins1 != "D" && cins1 != "S")
            {
                Console.WriteLine("hatalı tür girişi yaptınız..");
                goto Finish;
            }

            if (no1 == "1" || no1 == "2" || no1 == "3" || no1 == "4" || no1 == "5" || no1 == "6" || no1 == "7" || no1 == "8" || no1 == "9" || no1 == "10")
            {

            }
            else if (no1 == "k" || no1 == "K")
            {
                no1 = "13";
            }
            else if (no1 == "q" || no1 == "Q")
            {
                no1 = "12";
            }
            else if (no1 == "j" || no1 == "J")
            {
                no1 = "11";
            }
            else
            {
                Console.WriteLine("hatalı numara girişi yaptınız.");
                goto Finish;
            }



            if (cins2 != "C" && cins2 != "H" && cins2 != "D" && cins2 != "S")
            {
                Console.WriteLine("hatalı tür girişi yaptınız..");
                goto Finish;
            }

            if (no2 == "1" || no2 == "2" || no2 == "3" || no2 == "4" || no2 == "5" || no2 == "6" || no2 == "7" || no2 == "8" || no2 == "9" || no2 == "10")
            {

            }
            else if (no2 == "k" || no2 == "K")
            {
                no2 = "13";
            }
            else if (no2 == "q" || no2 == "Q")
            {
                no2 = "12";
            }
            else if (no2 == "j" || no2 == "J")
            {
                no2 = "11";
            }
            else
            {
                Console.WriteLine("hatalı numara girişi yaptınız.");
                goto Finish;
            }

            if (cins3 != "C" && cins3 != "H" && cins3 != "D" && cins3 != "S")
            {
                Console.WriteLine("hatalı tür girişi yaptınız..");
                goto Finish;
            }

            if (no3 == "1" || no3 == "2" || no3 == "3" || no3 == "4" || no3 == "5" || no3 == "6" || no3 == "7" || no3 == "8" || no3 == "9" || no3 == "10")
            {

            }
            else if (no3 == "k" || no3 == "K")
            {
                no3 = "13";
            }
            else if (no3 == "q" || no3 == "Q")
            {
                no3 = "12";
            }
            else if (no3 == "j" || no3 == "J")
            {
                no3 = "11";
            }
            else
            {
                Console.WriteLine("hatalı numara girişi yaptınız.");
                goto Finish;
            }
            if ((cins1 == cins2 && no1 == no2) || (cins1 == cins3 && no1 == no3) || (cins2 == cins3 && no2 == no3))
            {
                Console.WriteLine("iki tane aynı kart girişi yapamazsınız.");
                goto Finish;
            }

            //String olarak aldığımız kart numarasını  matematiksel işlemler yapabilmek için int'e çevirerek başka bir değişkene atadık.
            num1 = Convert.ToInt32(no1);
            num2 = Convert.ToInt32(no2);
            num3 = Convert.ToInt32(no3);




            //aynı cins olup olmadğının kontrolu.

            if (cins1 == cins2 && cins2 == cins3)
            {
                puan = puan + 5;
                puancase1 = 5;

                //eğer aynı cins ise sıralı olup olmadığının kontrolü.
                if ((num1 == num2 + 1 && num2 == num3 + 1) || (num1 == num3 + 1 && num3 == num2 + 1) || (num2 == num1 + 1 && num1 == num3 + 1) || (num2 == num3 + 1 && num3 == num1 + 1) || (

                        num3 == num1 + 1 && num1 == num2 + 1) || (num3 == num2 + 1 && num2 == num1 + 1) || ((num1 == 1 || num1 == 12 || num1 == 13) && (num2 == 1 || num2 == 12 || num2 == 13) && (num3 == 1 || num3 == 12 || num3 == 13)))
                {
                    puan = puan + 95;
                    puancase2 = 100;
                    puancase1 = 0;
                }
            }
            //aynı cins değilse tamamının farklı cins olup olmadığının kontrolu.
            else if (cins1 != cins2 && cins2 != cins3 && cins1 != cins3)
            {
                puan = puan + 1;
                puancase3 = 1;

                //farklı cinslerin sıralı olup olmadığının kontrolu.
                if ((num1 == num2 + 1 && num2 == num3 + 1) || (num1 == num3 + 1 && num3 == num2 + 1) || (num2 == num1 + 1 && num1 == num3 + 1) || (num2 == num3 + 1 && num3 == num1 + 1) || (

                        num3 == num1 + 1 && num1 == num2 + 1) || (num3 == num2 + 1 && num2 == num1 + 1))
                {
                    puan = puan + 20;
                    puancase4 = 20;
                }
            }
            else
            {
                //2 aynı 1 farklı cins durumunun sıralı olup olmadığı kontrolu.
                if ((num1 == num2 + 1 && num2 == num3 + 1) || (num1 == num3 + 1 && num3 == num2 + 1) || (num2 == num1 + 1 && num1 == num3 + 1) || (num2 == num3 + 1 && num3 == num1 + 1) || (

                        num3 == num1 + 1 && num1 == num2 + 1) || (num3 == num2 + 1 && num2 == num1 + 1) || ((num1 == 1 || num1 == 12 || num1 == 13) && (num2 == 1 || num2 == 12 || num2 == 13) && (num3 == 1 || num3 == 12 || num3 == 13)))
                {
                    puan = puan + 20;
                    puancase4 = 20;
                }
            }
            //kartların tamamının aynı numara olup olmadığının kontrolu.
            if (num1 == num2 && num2 == num3)
            {
                puan = puan + 80;
                puancase5 = 80;
            }
            //kartların hepsinin tek veya çift olma durumunun kontrolu.
            if (num1 % 2 == num2 % 2 && num2 % 2 == num3 % 2)
            {
                puan = puan + 2;
                puancase6 = 2;
            }
            //kartların sayısal değerleri toplamının 21 olma durumunun kontrolu.
            if (num1 + num2 + num3 == 21)
            {
                puan = puan + 4;
                puancase7 = 4;
            }
            //kartların tamamının kraliyet ailesinden olup olmadığı kontrolu.
            if ((num1 == 13 || num1 == 12 || num1 == 11) && (num2 == 13 || num2 == 12 || num2 == 13) && (num3 == 13 || num3 == 12 || num3 == 11))
            {
                puan = puan + 10;
                puancase8 = 10;
            }

            //Hangi şarttan ne kadar puan aldığımızı ayrı ayrı görüntledik.
            Console.Write("(");
            if (puancase1 != 0)
            {
                Console.Write(" " + puancase1 + "+");
            }
            if (puancase2 != 0)
            {
                Console.Write(" " + puancase2 + "+");
            }
            if (puancase3 != 0)
            {
                Console.Write(" " + puancase3 + "+");
            }
            if (puancase4 != 0)
            {
                Console.Write(" " + puancase4 + "+");
            }
            if (puancase5 != 0)
            {
                Console.Write(" " + puancase5 + "+");
            }
            if (puancase6 != 0)
            {
                Console.Write(" " + puancase6 + "+");
            }
            if (puancase7 != 0)
            {
                Console.Write(" " + puancase7 + "+");
            }
            if (puancase8 != 0)
            {
                Console.Write(" " + puancase8 + "+");
            }
            Console.WriteLine(")");

            //Alınan puannın yazdırılması
            Console.WriteLine("Puanınız = " + puan);
            Finish:
            Console.WriteLine("programsonu");
            Console.ReadLine();
        }
    }
}

