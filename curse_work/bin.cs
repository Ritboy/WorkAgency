using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace curse_work
{
    class bin
    {
        public void write_vakans(Vakans what, string where)
        {
            FileStream fi = new FileStream(where, FileMode.Append, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter
                              (fi, Encoding.Default);
            int dlina = what.dlina;
            int id = what.id;
            char[] dolzhnost = what.dolzhnost.ToCharArray();
            char[] company = what.company.ToCharArray();
            char[] phone = what.phone.ToCharArray();
            char[] opyt = what.opyt.ToCharArray();
            char[] otrasl = what.otrasl.ToCharArray();
            char[] zarplata = what.zarplata.ToCharArray();
            char[] zanyatost = what.zanyatost.ToCharArray();
            char[] education = what.education.ToCharArray();
            char[] opisanie = what.opisanie.ToCharArray();

            bw.Write(dlina);
            bw.Write(id);
            bw.Write(dolzhnost.Length);
            bw.Write(dolzhnost);
            bw.Write(company.Length);
            bw.Write(company);
            bw.Write(phone.Length);
            bw.Write(phone);
            bw.Write(opyt.Length);
            bw.Write(opyt);
            bw.Write(otrasl.Length);
            bw.Write(otrasl);
            bw.Write(zarplata.Length);
            bw.Write(zarplata);
            bw.Write(zanyatost.Length);
            bw.Write(zanyatost);
            bw.Write(education.Length);
            bw.Write(education);
            bw.Write(opisanie.Length);
            bw.Write(opisanie);
            bw.Close(); fi.Close();
        }
        public void rewrite_vakans(List<Vakans> list, string where)
        {
            FileStream fs = new FileStream(where, FileMode.Create);
            fs.Close();
            bin b = new bin();
            for (int i = 0; i < list.Count; i++)
                b.write_vakans(list[i], where);
        }
        public Vakans read_vakans(string path, int position)
        {
            BinaryReader br = new BinaryReader(
                    File.Open(path, FileMode.Open), Encoding.Default);
            br.BaseStream.Position = 0;
            int k;
            for (decimal i = 1; i < position; i++)
            {
                k = br.ReadInt32();
                br.BaseStream.Seek(k - 4, SeekOrigin.Current);
            }
            int dlina = br.ReadInt32();
            int id = br.ReadInt32();
            string dolzhnost = new string(br.ReadChars(br.ReadInt32()));
            string company = new string(br.ReadChars(br.ReadInt32()));
            string phone = new string(br.ReadChars(br.ReadInt32()));
            string opyt = new string(br.ReadChars(br.ReadInt32()));
            string otrasl = new string(br.ReadChars(br.ReadInt32()));
            string zarplata = new string(br.ReadChars(br.ReadInt32()));
            string zanyatost = new string(br.ReadChars(br.ReadInt32()));
            string education = new string(br.ReadChars(br.ReadInt32()));
            string opisanie = new string(br.ReadChars(br.ReadInt32()));
            br.Close();
            Vakans v = new Vakans();
            v.dlina = dlina;v.dolzhnost = dolzhnost;v.company = company;v.phone = phone; v.opyt = opyt; v.otrasl = otrasl; v.zarplata = zarplata; v.zanyatost = zanyatost; v.education = education; v.opisanie = opisanie;
            return v;
        }
        public List<Vakans> read_vakans(string path)
        {
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open), Encoding.Default);
            List<Vakans> vak = new List<Vakans>();
            try
            {
                while (true)
                {
                    int dlina = br.ReadInt32();
                    int id = br.ReadInt32();
                    string dolzhnost = new string(br.ReadChars(br.ReadInt32()));
                    string company = new string(br.ReadChars(br.ReadInt32()));
                    string phone = new string(br.ReadChars(br.ReadInt32()));
                    string opyt = new string(br.ReadChars(br.ReadInt32()));
                    string otrasl = new string(br.ReadChars(br.ReadInt32()));
                    string zarplata = new string(br.ReadChars(br.ReadInt32()));
                    string zanyatost = new string(br.ReadChars(br.ReadInt32()));
                    string education = new string(br.ReadChars(br.ReadInt32()));
                    string opisanie = new string(br.ReadChars(br.ReadInt32()));
                    Vakans v = new Vakans();
                    v.dlina = dlina; v.id = id; v.dolzhnost = dolzhnost; v.company = company; v.phone = phone; v.opyt = opyt; v.otrasl = otrasl; v.zarplata = zarplata; v.zanyatost = zanyatost; v.education = education; v.opisanie = opisanie;
                    vak.Add(v);
                }
            }
            catch (EndOfStreamException)
            {
                br.Close();
                return vak;
            }
        }

        ///// Rezume

        public void write_rezume(Rezume what, string where)
        {
            FileStream fi = new FileStream(where, FileMode.Append, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter
                              (fi, Encoding.Default);
            int dlina = what.dlina;
            int id = what.id;
            char[] lastname = what.lastname.ToCharArray();
            char[] name = what.name.ToCharArray();
            char[] dadname = what.dadname.ToCharArray();
            int age = what.age;
            char[] sex = what.sex.ToCharArray();
            char[] phone = what.phone.ToCharArray();
            char[] dolzhnost = what.dolzhnost.ToCharArray();
            char[] opyt = what.opyt.ToCharArray();
            char[] sfera = what.sfera.ToCharArray();
            char[] zarplata = what.zarplata.ToCharArray();
            char[] education = what.education.ToCharArray();
            char[] opisanie = what.opisanie.ToCharArray();

            bw.Write(dlina);
            bw.Write(id);
            bw.Write(lastname.Length);
            bw.Write(lastname);
            bw.Write(name.Length);
            bw.Write(name);
            bw.Write(dadname.Length);
            bw.Write(dadname);
            bw.Write(age);
            bw.Write(sex.Length);
            bw.Write(sex);
            bw.Write(phone.Length);
            bw.Write(phone);
            bw.Write(dolzhnost.Length);
            bw.Write(dolzhnost);
            bw.Write(education.Length);
            bw.Write(education);
            bw.Write(opyt.Length);
            bw.Write(opyt);
            bw.Write(sfera.Length);
            bw.Write(sfera);
            bw.Write(zarplata.Length);
            bw.Write(zarplata);
            bw.Write(opisanie.Length);
            bw.Write(opisanie);
            bw.Close(); fi.Close();
        }
        public void rewrite_rezume(List<Rezume> list, string where)
        {
            FileStream fs = new FileStream(where, FileMode.Create);
            fs.Close();
            bin b = new bin();
            for (int i = 0; i < list.Count; i++)
                b.write_rezume(list[i], where);
        }
        public List<Rezume> read_rezume(string path)
        {
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open), Encoding.Default);
            List<Rezume> rez = new List<Rezume>();
            try
            {
                while (true)
                {
                    int dlina = br.ReadInt32();
                    int id = br.ReadInt32();
                    string lastname = new string(br.ReadChars(br.ReadInt32()));
                    string name = new string(br.ReadChars(br.ReadInt32()));
                    string dadname = new string(br.ReadChars(br.ReadInt32()));
                    int age = br.ReadInt32();
                    string sex = new string(br.ReadChars(br.ReadInt32()));
                    string phone = new string(br.ReadChars(br.ReadInt32()));
                    string dolzhnost = new string(br.ReadChars(br.ReadInt32()));
                    string education = new string(br.ReadChars(br.ReadInt32()));
                    string opyt = new string(br.ReadChars(br.ReadInt32()));
                    string sfera = new string(br.ReadChars(br.ReadInt32()));
                    string zarplata = new string(br.ReadChars(br.ReadInt32()));
                    string opisanie = new string(br.ReadChars(br.ReadInt32()));
                    Rezume v = new Rezume();
                    v.dlina = dlina; v.id = id; v.lastname = lastname; v.name = name; v.dadname = dadname; v.age = age; v.sex = sex; v.phone = phone; v.dolzhnost = dolzhnost; v.education = education; v.opyt = opyt; v.sfera = sfera; v.zarplata = zarplata; v.opisanie = opisanie;
                    rez.Add(v);
                }
            }
            catch (EndOfStreamException)
            {
                br.Close();
                return rez;
            }
        }
    }
}
