using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string MaCaesar(string goc, int khoaso)
        {
            string loi = "1";
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            char[] re = goc.ToCharArray();
            for (int i = 0; i < re.Length; i++)
            {
                char kytu = re[i];
                if (kytu < 'A' || kytu > 'Z')
                {
                    return loi;
                }
                kytu = (char)(kytu + khoaso);
                if (kytu > 'Z')
                {
                    kytu = (char)(kytu - 26);
                }
                re[i] = kytu;
            }
            return new string(re);
        }
        static string GiaiCaesar(string goc, int khoaso)
        {
            string loi = "1";
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            char[] re = goc.ToCharArray();
            for (int i = 0; i < re.Length; i++)
            {
                char kytu = re[i];
                if (kytu < 'A' && kytu > 'Z')
                {
                    return loi;
                }
                kytu = (char)(kytu - khoaso);
                if (kytu < 'A')
                {
                    kytu = (char)(kytu + 26);
                }
                re[i] = kytu;
            }
            return new string(re);
        }
        static string MaPlayfair(string goc, string khoa)
        {
            string loi = "1";
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            goc = goc.Replace("J", "I");
            khoa = khoa.Replace(" ", "");
            char[] re = goc.ToArray();
            int dai = re.Length;
            for (int i = 0; i < dai - 1; i++)
            {
                if (re[i] == re[i + 1])
                {
                    if (re[i]=='X')
                    goc = goc.Replace(re[i] + "" + re[i], re[i] + "Q" + re[i]);
                    else goc = goc.Replace(re[i] + "" + re[i], re[i] + "X" + re[i]);
                    re = goc.ToArray();
                    dai++;
                }
            }
            if (goc.Length % 2 != 0)
                goc = goc + "Q";
            re = goc.ToArray();
            khoa = khoa.ToUpper();
            char[] ckhoa = khoa.ToArray();
            for (int i = 0; i < ckhoa.Length; i++)
                if (ckhoa[i] < 'A' || ckhoa[i] > 'Z') return loi;
            for (int i = 0; i < re.Length; i++)
                if (re[i] < 'A' || re[i] > 'Z') return loi;
            ckhoa = (bccPlayfair(khoa)).ToArray();
            for (int i = 0; i < re.Length; i = i + 2)
            {
                char kytu1 = re[i];
                int v1 = 0;
                char kytu2 = re[i + 1];
                int v2 = 0;
                for (int n = 0; n < ckhoa.Length; n++)
                    if (ckhoa[n] == re[i])
                        v1 = n;
                for (int n = 0; n < ckhoa.Length; n++)
                    if (ckhoa[n] == re[i + 1])
                        v2 = n;
                if ((v1 - v2) % 5 == 0 || (v2 - v1) % 5 == 0)
                {
                    if (v1 >= 20)
                    {
                        v1 = v1 - 25;
                    }
                    if (v2 >= 20)
                    {
                        v2 = v2 - 25;
                    }
                    re[i] = ckhoa[v1 + 5];
                    re[i + 1] = ckhoa[v2 + 5];
                }
                else
                {
                    if ((v1 >= 0 && v1 <= 4 && v2 >= 0 && v2 <= 4) ||
                        (v1 >= 5 && v1 <= 9 && v2 >= 5 && v2 <= 9) ||
                        (v1 >= 10 && v1 <= 14 && v2 >= 10 && v2 <= 14) ||
                        (v1 >= 15 && v1 <= 19 && v2 >= 15 && v2 <= 19) ||
                        (v1 >= 20 && v1 <= 24 && v2 >= 20 && v2 <= 24))
                    {
                        if ((v1 + 1) % 5 == 0)
                            v1 = v1 - 5;
                        if ((v2 + 1) % 5 == 0)
                            v2 = v2 - 5;
                        re[i] = ckhoa[v1 + 1];
                        re[i + 1] = ckhoa[v2 + 1];
                    }
                    else
                    {
                        int m = 0;
                        int n = 0;
                        if (v1 >= 0 && v1 <= 4) m = 0;
                        if (v1 >= 5 && v1 <= 9) m = 1;
                        if (v1 >= 10 && v1 <= 14) m = 2;
                        if (v1 >= 15 && v1 <= 19) m = 3;
                        if (v1 >= 20 && v1 <= 24) m = 4;
                        if (v2 >= 0 && v2 <= 4) n = 0;
                        if (v2 >= 5 && v2 <= 9) n = 1;
                        if (v2 >= 10 && v2 <= 14) n = 2;
                        if (v2 >= 15 && v2 <= 19) n = 3;
                        if (v2 >= 20 && v2 <= 24) n = 4;
                        int temp = m - n;
                        if (m - n > 0)
                        {
                            re[i] = ckhoa[v2 + 5 * temp];
                            re[i + 1] = ckhoa[v1 - 5 * temp];
                        }
                        if (m - n < 0)
                        {
                            temp = n - m;
                            re[i] = ckhoa[v2 - 5 * temp];
                            re[i + 1] = ckhoa[v1 + 5 * temp];
                        }
                    }
                }
            }
            return new string(re);
        }
        static string GiaiPlayfair(string goc, string khoa)
        {
            string loi = "1";
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            khoa = khoa.Replace(" ", "");
            char[] re = goc.ToArray();
            khoa = khoa.ToUpper();
            char[] ckhoa = khoa.ToArray();
            for (int i = 0; i < ckhoa.Length; i++)
                if (ckhoa[i] < 'A' || ckhoa[i] > 'Z') return loi;
            for (int i = 0; i < re.Length; i++)
                if (re[i] < 'A' || re[i] > 'Z') return loi;
            ckhoa = (bccPlayfair(khoa)).ToArray();
            for (int i = 0; i < re.Length; i = i + 2)
            {
                char kytu1 = re[i];
                int v1 = 0;
                char kytu2 = re[i + 1];
                int v2 = 0;
                for (int n = 0; n < ckhoa.Length; n++)
                    if (ckhoa[n] == re[i])
                        v1 = n;
                for (int n = 0; n < ckhoa.Length; n++)
                    if (ckhoa[n] == re[i + 1])
                        v2 = n;
                if ((v1 - v2) % 5 == 0 || (v2 - v1) % 5 == 0)
                {
                    if (v1 <= 5)
                    {
                        v1 = v1 + 25;
                    }
                    if (v2 <= 5)
                    {
                        v2 = v2 + 25;
                    }
                    re[i] = ckhoa[v1 - 5];
                    re[i + 1] = ckhoa[v2 - 5];
                }
                else
                {
                    if ((v1 >= 0 && v1 <= 4 && v2 >= 0 && v2 <= 4) ||
                        (v1 >= 5 && v1 <= 9 && v2 >= 5 && v2 <= 9) ||
                        (v1 >= 10 && v1 <= 14 && v2 >= 10 && v2 <= 14) ||
                        (v1 >= 15 && v1 <= 19 && v2 >= 15 && v2 <= 19) ||
                        (v1 >= 20 && v1 <= 24 && v2 >= 20 && v2 <= 24))
                    {
                        if (v1 % 5 == 0)
                            v1 = v1 + 5;
                        if (v2 % 5 == 0)
                            v2 = v2 + 5;
                        re[i] = ckhoa[v1 - 1];
                        re[i + 1] = ckhoa[v2 - 1];
                    }
                    else
                    {
                        int m = 0;
                        int n = 0;
                        if (v1 >= 0 && v1 <= 4) m = 0;
                        if (v1 >= 5 && v1 <= 9) m = 1;
                        if (v1 >= 10 && v1 <= 14) m = 2;
                        if (v1 >= 15 && v1 <= 19) m = 3;
                        if (v1 >= 20 && v1 <= 24) m = 4;
                        if (v2 >= 0 && v2 <= 4) n = 0;
                        if (v2 >= 5 && v2 <= 9) n = 1;
                        if (v2 >= 10 && v2 <= 14) n = 2;
                        if (v2 >= 15 && v2 <= 19) n = 3;
                        if (v2 >= 20 && v2 <= 24) n = 4;
                        int temp = m - n;
                        if (m - n > 0)
                        {
                            re[i] = ckhoa[v2 + 5 * temp];
                            re[i + 1] = ckhoa[v1 - 5 * temp];
                        }
                        if (m - n < 0)
                        {
                            temp = n - m;
                            re[i] = ckhoa[v2 - 5 * temp];
                            re[i + 1] = ckhoa[v1 + 5 * temp];
                        }
                    }
                }
            }
            return new string(re);
        }
        static string MaVigenere(string goc, string khoa)
        {
            string loi = "1";
            int vitri = 0;
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            char[] re = goc.ToArray();
            khoa = khoa.ToUpper();
            char[] ckhoa = khoa.ToArray();
            for (int i = 0; i < ckhoa.Length; i++)
                if (ckhoa[i] < 'A' || ckhoa[i] > 'Z')
                {
                    return loi;
                }
            for (int i = 0; i < re.Length; i++)
            {
                if (re[i] < 'A' || re[i] > 'Z')
                {
                    return loi;
                }
                vitri = i % ckhoa.Length;
                re[i] = (char)(re[i] + ckhoa[vitri] - 'A');
                if (re[i] > 'Z')
                {
                    re[i] = (char)(re[i] - 26);
                }
            }
            return new string(re);
        }
        static string GiaiVigenere(string goc, string khoa)
        {
            string loi = "1";
            int vitri = 0;
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            char[] re = goc.ToArray();
            khoa = khoa.ToUpper();
            char[] ckhoa = khoa.ToArray();
            for (int i = 0; i < ckhoa.Length; i++)
                if (ckhoa[i] < 'A' || ckhoa[i] > 'Z')
                {
                    return loi;
                }
            for (int i = 0; i < re.Length; i++)
            {
                if (re[i] < 'A' || re[i] > 'Z')
                {
                    return loi;
                }
                vitri = i % ckhoa.Length;
                re[i] = (char)(re[i] - ckhoa[vitri] + 'A');
                if (re[i] < 'A')
                {
                    re[i] = (char)(re[i] + 26);
                }
            }
            return new string(re);
        }
        public bool IsNumber(string kt)
        {
            foreach (char kytu in kt)
            {
                if (!Char.IsDigit(kytu))
                    return false;
            }
            return true;
        }
        static string bccPlayfair(string khoa)
        {
            char[] temp = new char[99];
            khoa = khoa.Replace(" ", "");
            khoa = khoa.ToUpper();
            khoa = khoa.Replace("J", "I");
            char[] bcc = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] kytu = khoa.ToArray();
            temp[0] = kytu[0];
            bool ktra = false;
            int dem = 0;
            int dem2 = 1;
            for (int i = 1; i <= kytu.Length; i++)
            {
                dem = i;
                if (i < kytu.Length)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if (temp[j] == kytu[i])
                        {
                            ktra = true;
                        }
                    }
                    if (ktra == false)
                    {
                        temp[dem2] = kytu[i];
                        dem2++;
                    }
                    else ktra = false;
                }
            }
            for (int i = dem; i < 25 + dem; i++)
            {
                if (i < bcc.Length + dem)
                {
                    for (int j = 0; j <= 24; j++)
                        if (temp[j] == bcc[i - dem])
                            ktra = true;
                    if (ktra == false)
                    {
                        temp[dem2] = bcc[i - dem];
                        dem2++;
                    }
                    else ktra = false;
                }
            }

            return new string(temp);
        }
        public void chuyennhiphan(string goc, string khoa, int[] arraykey, int[] arrayplain)
        {
            string t = "", k = "";
            char[] text = goc.ToCharArray();
            char[] key1 = khoa.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                int num1 = Int32.Parse(text[i].ToString(), System.Globalization.NumberStyles.HexNumber);
                int num2 = Int32.Parse(key1[i].ToString(), System.Globalization.NumberStyles.HexNumber);
                t += Convert.ToString(Convert.ToByte(num1), 2).PadLeft(4, '0');
                k += Convert.ToString(Convert.ToByte(num2), 2).PadLeft(4, '0');
            }
            for (int i = 0; i < arrayplain.Length; i++)
            {
                arrayplain[i] = int.Parse(t[i].ToString());
                arraykey[i] = int.Parse(k[i].ToString());
            }
        }
        public void KeyCompress1(int[] a, int[] b)
        {
            int[] PC1 = new int[]{
            57, 49, 41, 33, 25, 17, 9,
            1, 58, 50, 42, 34, 26, 18,
            10, 2, 59, 51, 43, 35, 27,
            19, 11, 3, 60, 52, 44, 36,
            63, 55, 47, 39, 31, 23, 15,
            7, 62, 54, 46, 38, 30, 22,
            14, 6, 61, 53, 45, 37, 29,
            21, 13, 5, 28, 20, 12, 4
            };
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = b[PC1[i] - 1];
            }
        }
        public int[] KeyLeftShift(int[] a, int k, int so)
        {
            int[] b = new int[28];
            if (so == 0)
            {
                for (int i = 0; i < 28; i++)
                {
                    int vitri = (i + k) % 28;
                    b[i] = a[vitri];
                }
            }
            else
            {
                for (int i = 0; i < 28; i++)
                {
                    int vitri = (28 + i + k) % 28;
                    b[i] = a[28+vitri];
                }
            }
            return b;
        }
        public void Key16(int[] arraykey1, List<int>[] keyleftshift)
        {
            keyleftshift[0] = new List<int>();
            keyleftshift[0].AddRange(arraykey1);
            
            for (int i = 1; i < 17; i++)
            {
                if (i == 1 || i == 2 || i == 9 || i == 16)
                {
                    keyleftshift[i] = new List<int>();
                    keyleftshift[i].AddRange(KeyLeftShift(keyleftshift[i - 1].ToArray(), 1, 0));//0: 28 so dau, 1: 28 so sau
                    keyleftshift[i].AddRange(KeyLeftShift(keyleftshift[i - 1].ToArray(), 1, 1));
                }
                else
                {
                    keyleftshift[i] = new List<int>();
                    keyleftshift[i].AddRange(KeyLeftShift(keyleftshift[i - 1].ToArray(), 2, 0));//0: 28 so dau, 1: 28 so sau
                    keyleftshift[i].AddRange(KeyLeftShift(keyleftshift[i - 1].ToArray(), 2, 1));

                }
            }
        }
        public void K16(List<int>[] k16, List<int>[] keyleftshift)
        {
            int[] a = new int[56];
            int[] b = new int[48];
            int[] PC2 = new int[]{
            14, 17, 11, 24, 1, 5,
            3, 28, 15, 6, 21, 10,
            23, 19, 12, 4, 26, 8,
            16, 7, 27, 20, 13, 2,
            41, 52, 31, 37, 47, 55,
            30, 40, 51, 45, 33, 48,
            44, 49, 39, 56, 34, 53,
            46, 42, 50, 36, 29, 32
            };
            for(int k=0; k<16; k++)
            {
                a = keyleftshift[k + 1].ToArray();
                for (int i = 0; i < PC2.Length; i++)
                {
                    if (i == 48)
                        break;
                    b[i] = a[PC2[i] - 1];
                }
                k16[k]= new List<int>();
                k16[k].AddRange(b);
            }
        }
        public int[] IP(int[] b)
        {
            int[] a = new int[64];
            int[] IP=new int[]{
            58, 50, 42, 34, 26, 18, 10, 2,
            60, 52, 44 ,36, 28, 20, 12 ,4,
            62 ,54 ,46 ,38 ,30 ,22 ,14 ,6,
            64 ,56, 48, 40, 32, 24 ,16, 8,
            57 ,49 ,41 ,33 ,25 ,17 ,9 ,1,
            59 ,51, 43 ,35 ,27 ,19 ,11, 3,
            61 ,53 ,45, 37, 29 ,21 ,13 ,5,
           63 ,55 ,47 ,39 ,31 ,23, 15, 7};
            for (int i = 0; i < IP.Length; i++)
            {
                a[i] = b[IP[i] - 1];
            }
            return a;
        }
        public int[] Divide(int[] a, int so)
        {
            int[] b = new int[32];
            if (so == 0)
            {                
                for (int i = 0; i < b.Length; i++)
                    b[i] = a[i];                
            }
            if (so == 1)
            {
                for (int i = 32; i < a.Length; i++)
                    b[i - 32] = a[i];
            }
            return b;
        }
        public int[] Expand32to48(int[] b)
        {
            int[] a=new int[48];
            int[] eTable = {
            32, 1, 2, 3, 4, 5,
            4 ,5 ,6 ,7 ,8 ,9,
            8 ,9 ,10 ,11 ,12 ,13,
            12 ,13 ,14 ,15 ,16 ,17,
            16, 17, 18, 19, 20, 21,
            20, 21, 22, 23, 24, 25,
            24, 25, 26, 27, 28, 29,
            28, 29, 30, 31, 32, 1};
            for (int i = 0; i < a.Length; i++)
            {
                a[i]=b[eTable[i]-1];
            }
            return a;
        }
        public int[] XOR(int[] a, int[] b) 
        {
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++) 
            {
                if (a[i] == b[i]) 
                    c[i] = 0;
                else
                    c[i] = 1;
            }
            return c;
        }
        public int[] SBox(int[] a)
        {
            int[,] S1 = new int[,]{
                {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7},
                {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
                {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
                {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}
            };
            int[,] S2 = new int[,]{
                {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10},
                {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
                {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
                {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}
            };
            int[,] S3 = new int[,]{
                {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8},
                {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
                {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
                {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12}
            };
            int[,] S4 = new int[,]{
                {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15},
                {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9},
                {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4},
                {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14}
            };
            int[,] S5 = new int[,]{
                {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9},
                {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6},
                {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14},
                {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3}
            };
            int[,] S6 = new int[,]{
                {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11},
                {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8},
                {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6},
                {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13}
            };
            int[,] S7 = new int[,]{
                {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1},
                {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6},
                {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2},
                {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12}
            };
            int[,] S8 = new int[,]{
                {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7},
                {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
                {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8},
                {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}
            };
            int k = 1;
            int[] sbox= new int[32];
            string s2="";
            for (int j = 0; j < a.Length; j = j + 6)
            {
                int x = 0, y = 0; //x= b0b5, y= b1b2b3b4
                string s = "";
                if (j == a.Length - 5)
                    break;
                x = Convert.ToInt32("00" + a[j].ToString() + a[j + 5].ToString(), 2);
                y = Convert.ToInt32(a[j + 1].ToString() + a[j + 2].ToString() + a[j + 3].ToString() + a[j + 4].ToString(), 2);
                
                if (k == 1)
                    s = S1[x, y].ToString();
                if (k == 2)
                    s = S2[x, y].ToString();
                if (k == 3)
                    s = S3[x, y].ToString();
                if (k == 4)
                    s = S4[x, y].ToString();
                if (k == 5)
                    s = S5[x, y].ToString();
                if (k == 6)
                    s = S6[x, y].ToString();
                if (k == 7)
                    s = S7[x, y].ToString();
                if (k == 8)
                    s = S8[x, y].ToString();
                if (k > 8)
                    break;
                else
                    s2 += Convert.ToString(Convert.ToByte(s), 2).PadLeft(4, '0');
                k++;
            }
            for (int l = 0; l < 32; l++)
            {
                sbox[l] = int.Parse(s2[l].ToString());
            }
            return sbox;
        }
        public int[] Pbox(int[] a)
        {           
            int[] b = new int[32];
            int[] P = {
                16, 7, 20, 21,
                29, 12, 28, 17,
                1, 15, 23, 26,
                5, 18, 31, 10,
                2, 8, 24, 14,
                32, 27, 3, 9,
                19, 13, 30, 6,
                22, 11, 4, 25
            };
            for (int i = 0; i < P.Length; i++)
            {
                b[i] = a[P[i] - 1];
            }
            return b;
        }
        public int[] IP_1(int[] a, int[] b)
        {
            int[] c= new int[64];
            int[] d = new int[64];
            int[] IP_1 = new int[64]{
                40, 8, 48, 16, 56, 24, 64, 32,
                39, 7, 47, 15, 55, 23, 63, 31,
                38, 6, 46, 14, 54, 22, 62, 30,
                37, 5, 45, 13, 53, 21, 61, 29,
                36, 4, 44, 12, 52, 20, 60, 28,
                35, 3, 43, 11, 51, 19, 59, 27,
                34, 2, 42, 10, 50, 18, 58, 26,
                33, 1, 41, 9, 49, 17, 57, 25
            };
            for (int i = 0; i < 64; i++)
            {
                if (i < 32)
                    c[i] = a[i];
                else
                {
                    //if (i == 64)
                    //    break;
                    c[i] = b[i - 32];
                }
            }
            for (int j = 0; j < IP_1.Length; j++)
                d[j] = c[IP_1[j] - 1];
            return d;
        }
        public string BinaryToHex(int[] a)
        {
            string b="";
            string c="";
            for (int i = 1; i <= 64; i++)
            {
                c += a[i - 1].ToString();
                if (i % 4 == 0 && i > 0)
                {
                    b += Convert.ToInt32(c, 2).ToString("X");
                    c = "";
                }
            }
            return b;
        }
        static string kiemtra(string goc, string khoa)
        {
            string loi = "0";
            goc=goc.Replace(" ","");
            goc=goc.ToUpper();
            khoa = khoa.Replace(" ", "");
            khoa = khoa.ToUpper();
            char[] ktkhoa = khoa.ToCharArray();
            char[] ktgoc = goc.ToCharArray();
            if (ktgoc.Length != 16)
            {
                return loi = "1";
            }
            if (ktkhoa.Length != 16)
                return loi = "2";
            for (int i = 0; i<=15;i++)
            {
                if ((ktgoc[i]<'A'||ktgoc[i]>'F')&&(ktgoc[i]<'0'||ktgoc[i]>'9'))
                    return loi = "3";
                if ((ktkhoa[i]<'A'||ktkhoa[i]>'F')&&(ktkhoa[i]<'0'||ktkhoa[i]>'9'))
                    return loi = "4";
            }
            return loi;
        }
        public string MaDES(string goc, string khoa, int[] arraykey, int[] arraykey1, int[] arrayplain, List<int>[] keyleftshift, List<int>[] k16)
        {
            List<int>[] L= new List<int>[17];
            List<int>[] R = new List<int>[17];
            chuyennhiphan(goc,khoa,arraykey,arrayplain);
            KeyCompress1(arraykey1,arraykey);
            Key16(arraykey1,keyleftshift);
            K16(k16,keyleftshift);
            L[0] = new List<int>();
            R[0] = new List<int>();
            L[0].AddRange(Divide(IP(arrayplain), 0));
            R[0].AddRange(Divide(IP(arrayplain), 1));
            for (int i = 1; i < 17; i++)
            {
                L[i] = new List<int>();
                R[i] = new List<int>();
                L[i].AddRange(R[i - 1]);
                R[i].AddRange(XOR(L[i - 1].ToArray(), Pbox(SBox(XOR(k16[i-1].ToArray(), Expand32to48(R[i - 1].ToArray()))))));
            }
            return BinaryToHex(IP_1(R[16].ToArray(), L[16].ToArray()));
            
        }
        public string GiaiDES(string goc, string khoa, int[] arraykey, int[] arraykey1, int[] arrayplain, List<int>[] keyleftshift, List<int>[] k16)
        {
            List<int>[] L = new List<int>[17];
            List<int>[] R = new List<int>[17];
            chuyennhiphan(goc, khoa,arraykey,arrayplain);
            KeyCompress1(arraykey1, arraykey);
            Key16(arraykey1,keyleftshift);
            K16(k16,keyleftshift);
            L[16] = new List<int>();
            R[16] = new List<int>();
            L[16].AddRange(Divide(IP(arrayplain), 0));
            R[16].AddRange(Divide(IP(arrayplain), 1));
            for (int i = 15; i >=0; i--)
            {
                L[i] = new List<int>();
                R[i] = new List<int>();
                L[i].AddRange(R[i + 1]);
                R[i].AddRange(XOR(L[i + 1].ToArray(), Pbox(SBox(XOR(k16[i].ToArray(), Expand32to48(R[i + 1].ToArray()))))));
            }
            return BinaryToHex(IP_1(R[0].ToArray(), L[0].ToArray()));
        }
        static string BangHEX(char x)
        {
            string re = "";
            if (x == '0') re = "30";
            if (x == '1') re = "31";
            if (x == '2') re = "32";
            if (x == '3') re = "33";
            if (x == '4') re = "34";
            if (x == '5') re = "35";
            if (x == '6') re = "36";
            if (x == '7') re = "37";
            if (x == '8') re = "38";
            if (x == '9') re = "39";
            if (x == 'A') re = "41";
            if (x == 'B') re = "42";
            if (x == 'C') re = "43";
            if (x == 'D') re = "44";
            if (x == 'E') re = "45";
            if (x == 'F') re = "46";
            if (x == 'G') re = "47";
            if (x == 'H') re = "48";
            if (x == 'I') re = "49";
            if (x == 'J') re = "4A";
            if (x == 'K') re = "4B";
            if (x == 'L') re = "4C";
            if (x == 'M') re = "4D";
            if (x == 'N') re = "4E";
            if (x == 'O') re = "4F";
            if (x == 'P') re = "50";
            if (x == 'Q') re = "51";
            if (x == 'R') re = "52";
            if (x == 'S') re = "53";
            if (x == 'T') re = "54";
            if (x == 'U') re = "55";
            if (x == 'V') re = "56";
            if (x == 'W') re = "57";
            if (x == 'X') re = "58";
            if (x == 'Y') re = "59";
            if (x == 'Z') re = "5A";
            return re;
        }
        static string BangASC(string x)
        {
            string re = "";
            if (x == "30") re = "0";
            if (x == "31") re = "1";
            if (x == "32") re = "2";
            if (x == "33") re = "3";
            if (x == "34") re = "4";
            if (x == "35") re = "5";
            if (x == "36") re = "6";
            if (x == "37") re = "7";
            if (x == "38") re = "8";
            if (x == "39") re = "9";
            if (x == "41") re = "A";
            if (x == "42") re = "B";
            if (x == "43") re = "C";
            if (x == "44") re = "D";
            if (x == "45") re = "E";
            if (x == "46") re = "F";
            if (x == "47") re = "G";
            if (x == "48") re = "H";
            if (x == "49") re = "I";
            if (x == "4A") re = "J";
            if (x == "4B") re = "K";
            if (x == "4C") re = "L";
            if (x == "4D") re = "M";
            if (x == "4E") re = "N";
            if (x == "4F") re = "O";
            if (x == "50") re = "P";
            if (x == "51") re = "Q";
            if (x == "52") re = "R";
            if (x == "53") re = "S";
            if (x == "54") re = "T";
            if (x == "55") re = "U";
            if (x == "56") re = "V";
            if (x == "57") re = "W";
            if (x == "58") re = "X";
            if (x == "59") re = "Y";
            if (x == "5A") re = "Z";
            return re;
        }
        static string ChuyenGoc(string goc)
        {
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            string re = "";
            if (goc.Length<8)
            {
                int dai = 8 - goc.Length;
                for (int i = 0; i < dai; i++)
                    goc = goc + "0";
            }
            char[] tam = goc.ToArray();
            for (int i = 0; i < goc.Length; i++)
                re = re + BangHEX(tam[i]);
            return re;
        }
        static string ChuyenRe(string goc)
        {
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            string re = "";
            for (int i = 0; i < 8; i++)
                re = re + BangASC(goc.Substring(i * 2, 2));
            return re;
        }
        public string kiemtraASC(string goc, string khoa)
        {
            string loi = "0";
            goc = goc.Replace(" ", "");
            goc = goc.ToUpper();
            khoa = khoa.Replace(" ", "");
            khoa = khoa.ToUpper();
            char[] ktkhoa = khoa.ToArray();
            char[] ktgoc = goc.ToArray();

            if (ktgoc.Length > 8 )
            {
                if (mahoaUI.Checked)
                    return loi = "1";
            }
            if (ktgoc.Length != 16)
            {
                if (dichmaUI.Checked)
                    return loi = "5";
            }
            if (ktkhoa.Length != 16)
                return loi = "2";
            for (int i = 0; i < ktgoc.Length; i++)
            {
                if (dichmaUI.Checked)
                {
                    if ((ktgoc[i] < 'A' || ktgoc[i] > 'F') && (ktgoc[i] < '0' || ktgoc[i] > '9'))
                        return loi = "6";
                }
            }
            for (int i = 0; i < ktgoc.Length; i++)
            {
                if (mahoaUI.Checked)
                {
                    if ((ktgoc[i] < 'A' || ktgoc[i] > 'Z') && (ktgoc[i] < '0' || ktgoc[i] > '9'))
                        return loi = "3";
                }
            }
            for (int i = 0; i <= 15; i++)
            {
                if ((ktkhoa[i] < 'A' || ktkhoa[i] > 'F') && (ktkhoa[i] < '0' || ktkhoa[i] > '9'))
                    return loi = "4";
            }
            return loi;
        }
        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            if (gocUI.Text != "" && khoaUI.Text != "")
            {
                string goc, re, khoa;
                re = "";
                goc = gocUI.Text;
                khoa = khoaUI.Text;
                if (caesarUI.Checked)
                {
                    if (IsNumber(khoa)==true)
                    {
                        int khoaso = int.Parse(khoa);
                        if (khoaso < 0 || khoaso > 26)
                            MessageBox.Show("HÃY CHỌN KHOÁ TRONG KHOẢNG TỪ 0 ĐẾN 26!!!");
                        else
                        {
                            if (mahoaUI.Checked)
                                re = MaCaesar(goc, khoaso);
                            if (dichmaUI.Checked)
                                re = GiaiCaesar(goc, khoaso);
                            khoaso = 0;
                        }
                    }
                    else MessageBox.Show("KHOÁ CỦA CAESAR PHẢI LÀ SỐ!!!");
                }
                if (playfairUI.Checked)
                {
                    if (!IsNumber(khoa))
                    {
                        if (mahoaUI.Checked)
                            re = MaPlayfair(goc, khoa);
                        if (dichmaUI.Checked)
                            re = GiaiPlayfair(goc, khoa);
                    }
                    else MessageBox.Show("KHOÁ CỦA PLAYFAIR PHẢI LÀ CHỮ CÁI!!!");
                }
                if (vigenereUI.Checked)
                {
                    if (!IsNumber(khoa))
                    {
                        if (mahoaUI.Checked)
                            re = MaVigenere(goc, khoa);
                        if (dichmaUI.Checked)
                            re = GiaiVigenere(goc, khoa);
                    }
                    else MessageBox.Show("KHOÁ CỦA VIGENERE PHẢI LÀ CHỮ CÁI!!!");
                }
                if (DESUI.Checked)
                {
                    if (kiemtra(goc, khoa) == "0")
                    {
                        int[] arrayplain = new int[64];
                        int[] arraykey = new int[64];
                        int[] arraykey1 = new int[56];
                        List<int>[] keyleftshift = new List<int>[17];
                        List<int>[] k16 = new List<int>[16];
                        List<int>[] plaintext16 = new List<int>[16];
                        if (mahoaUI.Checked)
                        {
                            re = MaDES(goc, khoa, arraykey, arraykey1, arrayplain, keyleftshift, k16);
                        }
                        if (dichmaUI.Checked)
                            re = GiaiDES(goc, khoa, arraykey, arraykey1, arrayplain, keyleftshift, k16);
                    }
                    if (kiemtra(goc, khoa) == "1")
                        MessageBox.Show("ĐOẠN MÃ PHẢI ĐỦ 16 KÝ TỰ, KHÔNG TÍNH KHOẢNG TRẮNG!!!");
                    if (kiemtra(goc, khoa) == "2")
                        MessageBox.Show("KHOÁ PHẢI ĐỦ 16 KÝ TỰ!!!");
                    if (kiemtra(goc, khoa) == "3")
                        MessageBox.Show("ĐOẠN MÃ PHẢI LÀ HEXA!!!");
                    if (kiemtra(goc, khoa) == "4")
                        MessageBox.Show("KHOÁ PHẢI LÀ HEXA!!!");
                }
                if (DESAUI.Checked)
                {
                    string kiemtra = kiemtraASC(goc, khoa);
                    if (kiemtra == "0")
                    {
                        int[] arrayplain = new int[64];
                        int[] arraykey = new int[64];
                        int[] arraykey1 = new int[56];
                        List<int>[] keyleftshift = new List<int>[17];
                        List<int>[] k16 = new List<int>[16];
                        List<int>[] plaintext16 = new List<int>[16];
                        if (mahoaUI.Checked)
                        {
                            goc = ChuyenGoc(goc);
                            re = MaDES(goc, khoa, arraykey, arraykey1, arrayplain, keyleftshift, k16);
                        }
                        if (dichmaUI.Checked)
                        {
                            re = GiaiDES(goc, khoa, arraykey, arraykey1, arrayplain, keyleftshift, k16);
                            re = ChuyenRe(re);
                        }
                    }
                    if (kiemtra == "1")
                        MessageBox.Show("ĐOẠN MÃ PHẢI ÍT HƠN 8 KÝ TỰ, KHÔNG TÍNH KHOẢNG TRẮNG!!!");
                    if (kiemtra == "2")
                        MessageBox.Show("KHOÁ PHẢI ĐỦ 16 KÝ TỰ!!!");
                    if (kiemtra == "3")
                        MessageBox.Show("ĐOẠN MÃ CHỨA KÝ TỰ KHÔNG HỢP LỆ!!!");
                    if (kiemtra == "4")
                        MessageBox.Show("KHOÁ PHẢI LÀ HEXA!!!");
                    if (kiemtra == "5")
                        MessageBox.Show("ĐOẠN DỊCH PHẢI ĐỦ 16 KÝ TỰ!!!");
                    if (kiemtra == "6")
                        MessageBox.Show("ĐOẠN DỊCH PHẢI LÀ HEXA!!!");
                }
                if (re == "1")
                    MessageBox.Show("LỖI NHẬP LIỆU!!!");
                else reUI.Text = re;
                goc = ""; re = ""; khoa = "";
            }
            else
                MessageBox.Show("XIN HÃY NHẬP VĂN BẢN HOẶC KHOÁ!!!");
        }
        private void File_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                khoaUI.Text = "";
                using (StreamReader mofile = new StreamReader("d:/key.txt"))
                {
                    khoaUI.Text = mofile.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("KHÔNG THỂ ĐỌC FILE, XIN KIỂM TRA FILE \"key.txt\" LƯU TẠI Ổ D:");
            }

        }
    }
}
