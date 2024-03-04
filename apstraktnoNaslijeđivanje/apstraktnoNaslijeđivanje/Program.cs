using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apstraktnoNaslijeđivanje
{
    internal class Program
    {
        public abstract class Brod
        {
            public string naziv;
            public string m_vrsta;
            public int m_zdravlje;
            public int m_snaga;
            public Oruzje[] m_spremnik;

            public abstract void napad(Brod neprijatelj);
            public abstract void promjeni_oruzje(Oruzje novo_oruzje);
            public abstract void dodaj(Oruzje oruzje);
            public abstract void odaberi_oruzje();
            public abstract void ispis();
            public abstract void moc(Brod brod);
            public abstract int tezina();
        }

        public class Oruzje
        {
            public string m_naziv;
            public string m_vrsta;
            public int m_snaga;
            public int m_tezina;

            public Oruzje(string naziv, string vrsta, int snaga, int tezina)
            {
                m_naziv = naziv;
                m_vrsta = vrsta;
                m_snaga = snaga;
                m_tezina = tezina;
            }
        }

        public class Brod1 : Brod
        {
            public Brod1(string naziv, string vrsta, int zdravlje, int snaga)
            {
                this.naziv = naziv;
                m_vrsta = vrsta;
                m_zdravlje = zdravlje;
                m_snaga = snaga;
                m_spremnik = new Oruzje[10];
            }

            public override void napad(Brod neprijatelj)
            {
                neprijatelj.m_zdravlje -= m_snaga;
                Console.WriteLine("{0} pogodio je {1} za {2}", naziv, neprijatelj.naziv, m_snaga);
            }

            public override void promjeni_oruzje(Oruzje novo_oruzje)
            {
                m_snaga = novo_oruzje.m_snaga;
                Console.WriteLine("Streljivo je promjenjeno!");
            }

            public override void dodaj(Oruzje oruzje)
            {
                for (int i = 0; i < m_spremnik.Length; i++)
                {
                    if (m_spremnik[i] == null)
                    {
                        m_spremnik[i] = oruzje;
                        break;
                    }
                }
            }

            public override void odaberi_oruzje()
            {
                foreach (Oruzje oruzje in m_spremnik)
                {
                    if (oruzje != null)
                    {
                        Console.WriteLine("{0} odabire {1} iz spremnika!", naziv, oruzje.m_naziv);
                        return;
                    }
                }
                Console.WriteLine("{0} nema odabranog streljiva u spremniku!", naziv);
            }

            public override void ispis()
            {
                Console.WriteLine("Naziv: {0} \n Vrsta: {1} \n Zdravlje: {2} \n Snaga: {3} \n", naziv, m_vrsta, m_zdravlje, m_snaga);
                Console.WriteLine("\n Bojni komplet: \n");

                foreach (Oruzje oruzje in m_spremnik)
                {
                    if (oruzje != null)
                    {
                        Console.WriteLine("Naziv: {0} \n Vrsta: {1} \n Snaga: {2} \n Tezina: {3}", oruzje.m_naziv, oruzje.m_vrsta, oruzje.m_snaga, oruzje.m_tezina);
                    }
                }
            }

            public override void moc(Brod brod)
            {
                brod.m_snaga += 20;
            }

            public override int tezina()
            {
                int tezina = 0;

                foreach (Oruzje oruzje in m_spremnik)
                {
                    if (oruzje != null)
                    {
                        tezina += oruzje.m_tezina;
                    }
                }
                return tezina;
            }
        }

        public class Brod2 : Brod
        {
            public Brod2(string naziv, string vrsta, int zdravlje, int snaga)
            {
                this.naziv = naziv;
                m_vrsta = vrsta;
                m_zdravlje = zdravlje;
                m_snaga = snaga;
                m_spremnik = new Oruzje[10];
            }

            public override void napad(Brod neprijatelj)
            {
                neprijatelj.m_zdravlje -= m_snaga;
                Console.WriteLine("{0} pogodio je {1} za {2}", naziv, neprijatelj.naziv, m_snaga);
            }

            public override void promjeni_oruzje(Oruzje novo_oruzje)
            {
                m_snaga = novo_oruzje.m_snaga;
                Console.WriteLine("Streljivo je promjenjeno!");
            }

            public override void dodaj(Oruzje oruzje)
            {
                for (int i = 0; i < m_spremnik.Length; i++)
                {
                    if (m_spremnik[i] == null)
                    {
                        m_spremnik[i] = oruzje;
                        break;
                    }
                }
            }

            public override void odaberi_oruzje()
            {
                foreach (Oruzje oruzje in m_spremnik)
                {
                    if (oruzje != null)
                    {
                        Console.WriteLine("{0} odabire {1} iz spremnika!", naziv, oruzje.m_naziv);
                        return;
                    }
                }
                Console.WriteLine("{0} nema odabranog streljiva u spremniku!", naziv);
            }

            public override void ispis()
            {
                Console.WriteLine("\n Naziv: {0} \n Vrsta: {1} \n Zdravlje: {2} \n Snaga: {3} \n", naziv, m_vrsta, m_zdravlje, m_snaga);
                Console.WriteLine("\n Bojni komplet: \n");

                foreach (Oruzje oruzje in m_spremnik)
                {
                    if (oruzje != null)
                    {
                        Console.WriteLine("\n Naziv: {0} \n Vrsta: {1} \n Snaga: {2} \n Tezina: {3}", oruzje.m_naziv, oruzje.m_vrsta, oruzje.m_snaga, oruzje.m_tezina);
                    }
                }
            }

            public override void moc(Brod brod)
            {
                brod.m_zdravlje += 5;
            }

            public override int tezina()
            {
                int tezina = 0;

                foreach (Oruzje oruzje in m_spremnik)
                {
                    if (oruzje != null)
                    {
                        tezina += oruzje.m_tezina;
                    }
                }
                return tezina;
            }
        }

        static void Main(string[] args)
        {
           

            Brod1 brod1 = new Brod1("Abyssinia", "Glavni Borbeni Brod", 1200, 130);
            Oruzje Topv1 = new Oruzje("topv1", "APS", 120, 6);
            Oruzje nuklearnabomba = new Oruzje("nuklearna bomba", "ATGM", 1000, 170);

            brod1.dodaj(Topv1);
            brod1.dodaj(nuklearnabomba);
            brod1.ispis();

           

            Brod2 brod2 = new Brod2("Conqueror", "Glavni Borbeni Brod", 2400, 120);
            Oruzje Topv2 = new Oruzje("Topv2", "APS", 120, 6);
            

            brod2.dodaj(Topv2);
            brod2.ispis();

            

            brod1.napad(brod2);
            brod2.napad(brod1);
            brod1.promjeni_oruzje(nuklearnabomba);
            brod1.moc(brod1);
            brod1.napad(brod2);
            brod2.ispis();
            brod2.napad(brod1);
            brod1.ispis();

            Console.ReadKey();
        }
    }
}
