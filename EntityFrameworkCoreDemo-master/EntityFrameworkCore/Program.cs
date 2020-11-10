using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EntityFrameworkCore
{
   public class Program
    {
        public const string ArraySize = "Mustn't Be Zero";
        public const string ListSize = "List Length Must Be Zero! Array Length Mustn't Be Zero";
        public const string ListSize11 = "Array Length Is Zero or List Length is More than zero";
        public const string ListSize1 = "Must Be More Than Zero!";

        //Sami Metodi Tavisi If-it da Else-bit gavakete Testirebistvis! Sinamdvileshi yvela es kodi Main-shi mewera! Shesabamisad
        //Testebis Meshveobit Vamowmeb 3 Rames! 
        //1)Failis Kitxvas Stringebis Masivis Meshveobit! Stringis Masivis Sigrdze Ar Unda Iyos Failis Sigrdzeze Naklebi! 
        //Winaaghmedeg Shemtxvevashi Agdebs Exception-s
        //2)Am Stringebis Masividan StudentSubject List-Shi Monacemebis Gadawera-Konvertacias!
        //StudentSubject-is Sawyisi Sigrdze Ar unda Iyos 0-ze meti! Winaaghmdeg Shemtxvevashi programa agdebs Exceptions!
        //3)Am Listidan ki Bazashi Shesabamisi Chanaweris Bazashi Gadaweras! Aq listi Ar unda iyos 0! Winaaghmdeg Shemtxvevashi Programa Isvris Exception-s!
        public static string [] ReadFile(string [] z1, int q)
        {
            if(q>= File.ReadAllLines("C:/Users/Nikusha/Desktop/EntityFrameworkCoreDemo-master/EntityFrameworkCore/Grades.csv").Length)
            {
                z1 = new string[q];
                for (int i = 0; i < File.ReadAllLines("C:/Users/Nikusha/Desktop/EntityFrameworkCoreDemo-master/EntityFrameworkCore/Grades.csv").Length; i++)
                    z1[i] = File.ReadAllLines("C:/Users/Nikusha/Desktop/EntityFrameworkCoreDemo-master/EntityFrameworkCore/Grades.csv")[i];
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Size Of File",q, ArraySize);
            }
            return z1;
        }
        public static List<StudentSubject> FillList(List<StudentSubject> StudSubj,string [] z1)
        {                       
            if (StudSubj.Count == 0 && z1.Length>0) 
            {
                for(int i = 1; i < z1.Length; i++)
                {
                    StudSubj.Add(new StudentSubject() { StudentId = Convert.ToInt32(z1[i].Split(",")[0]), SubjectId = Convert.ToInt32(z1[i].Split(",")[1]), Grade = Convert.ToInt32(z1[i].Split(",")[2]) });
                }
            }
            
            else
                throw new System.ArgumentOutOfRangeException("Size of List",ListSize11);
            return StudSubj;
        }
        public static int WriteInDatabase(List<StudentSubject> StudSubj,int z,Mid_Exam7 db)
        {
            int k = 0;
            if(StudSubj.Count>0)
            {
                for (int j = 0; j < StudSubj.Count; j++)
                {
                    for (int i = 0; i < z; i++)
                    {
                        if (StudSubj[j].StudentId == db.StudentSubjects.ToArray()[i].StudentId && StudSubj[j].SubjectId == db.StudentSubjects.ToArray()[i].SubjectId)
                        {
                            //Qulis Chawera
                            db.StudentSubjects.ToArray()[i].Grade = StudSubj[j].Grade;
                            db.SaveChanges();

                            //Warmatebit Daimportebuli Qulebi
                            Console.WriteLine("Warmatebit Daimportda Shemdegi Monacemi:StudentId - " + StudSubj[j].StudentId
                                + " ,SubjectId - " + StudSubj[j].SubjectId + " ,Grade - " + StudSubj[j].Grade);
                            //StudSubj.Remove - s viyeneb imitom, rom vinaidan da radganac swori monacemebi ukve chaiwera
                            //mashin List-dan da ara bazidan, misi washlit mxolod araswori monacemebi gvrcheba, rac gvimartivebs sakitxs!
                            StudSubj.Remove(StudSubj[j]);
                            //Warmatebit Daimportebuli Chanawerebis Gazrda
                            k++;
                        }

                    }
                }
            } 
            else
            {
                throw new System.ArgumentOutOfRangeException("Size Of List", StudSubj.Count, ListSize1);
            }
            return k;
        }
        public static void Main(string[] args)
        {           
            using (Mid_Exam7 db = new Mid_Exam7())
            {
                Console.WriteLine("Subject Cxrilshi Chaiwera 5 Saganis Saxeli!");
                Console.WriteLine("Students Cxrilshi Chaiwera 50 Studentis Saxeli!");
                Console.WriteLine("StudentSubjects Cxrilshi Chaiwera 100 Monacemi");
                string[] m1 = new string[] { };
                int v = File.ReadAllLines("C:/Users/Nikusha/Desktop/EntityFrameworkCoreDemo-master/EntityFrameworkCore/Grades.csv").Length;
                //Failis Kitxva
                m1 = ReadFile(m1,v);                                              
                //StudentsSubject Cxrilis Length-is Minicheba, Romelsac Amave Kodshi Viyenebt
                int z = db.StudentSubjects.ToArray().Length;
                //Listis Sheqmna
                List<StudentSubject> StudSubj = new List<StudentSubject>();
                //Listis Shevseba
                StudSubj=FillList(StudSubj,m1);               
                //i1 Warmoadgens Warmatebit Chaweril Monacemta Raodenobis Aghmnishvnels.Tavidan Is Nulia!
                //WriteInDatabase Metodis Gamotenebit ki Bazashi Vwer Grade-is Shesabamis Mnishvnelobebs!
                int i1 = WriteInDatabase(StudSubj,z,db);
                //Warmatebulad Daimportebulebis Raodenoba
                Console.WriteLine("StudentSubject Bazashi Chaiwera " + i1 + " Cali Qula!");
                //Warumateblad Daimportebulebi
                for (int i = 0; i < StudSubj.Count; i++)
                {
                    Console.WriteLine("Warumateblad Daimportda Shemdegi Monacemi: StudentId - " + StudSubj[i].StudentId
                                + " ,SubjectId - " + StudSubj[i].SubjectId + " ,Grade - " + StudSubj[i].Grade);
                }
                //Warumateblad Daimportebulebis Raodenoba
                int z1 = m1.Length - 1 - i1;
                Console.WriteLine("StudentSubject Bazashi Ver Chaiwera " + z1 + " Cali Qula");
                //Ucvlelta Raodenoba
                int z2 = z - i1;
                Console.WriteLine("Bazashi Ucvleli Darcha " + z2 + " Monacemi!");
            }
        }
    }

    public class Mid_Exam7 : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Subject> Subject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-UNEAH8K;database=Mid_Exam7;Integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //Vqmni Subjectebis List-s Da Vanicheb Mnishvnelobebs
            List<Subject> Subj = new List<Subject>();
            {
                Subj.Add(new Subject() { SubjectId = 1, SubjectName = "Daprogrameba" });
                Subj.Add(new Subject() { SubjectId = 2, SubjectName = "Matematika" });
                Subj.Add(new Subject() { SubjectId = 3, SubjectName = "Fizika" });
                Subj.Add(new Subject() { SubjectId = 4, SubjectName = "Qartuli" });
                Subj.Add(new Subject() { SubjectId = 5, SubjectName = "Geografia" });
            }
            //Hasdata-s Meshveobit Bazashi Vwer Listis SubjectId-s da SubjectName-s
            for (int i = 0; i < Subj.Count; i++)
            {
                modelbuilder.Entity<Subject>().HasData(
               new Subject() { SubjectId = Subj[i].SubjectId, SubjectName = Subj[i].SubjectName }   ////Pirveli Sagani               
               );
            }
            //Saxelebi Student Lististvis
            string[] Names = new string[] { "Zurab", "Ana", "Mariam", "Estate", "Teimurazi", "Ekaterine", "Anastasia" }; // Saxelebis Masivi
            //Random
            Random rnd = new Random();
            //Vqmni Studentebis List-s Da Vanicheb Mnishvnelobebs! Shemdeg Ki HasData-s Meshveobit Mat Vwer Bazashi!
            List<Student> Stud = new List<Student>();
            for (int i = 0; i < 50; i++)
            {
                Stud.Add(new Student() { StudentId = i + 1, StudentName = Names[rnd.Next(0, Names.Length)] });
                modelbuilder.Entity<Student>().HasData(
                      new Student() { StudentId = Stud[i].StudentId, StudentName = Stud[i].StudentName } //50 Studenti
                      );
            }
            // z-s viyeneb StudentSubjectId- s mnishvnelobebistvis
            int z = 1;
            //HasData Metodis Gamoyenebit Vwer 50-ive Students da Random it shercheul 2 Sagans StudentSubject Klasshi.
            //Sabolood 100 Chanaweri!
            //Random-ebshi Ase Imitom Gavakete, rom Xshirad Erti Da Igive Studentistvis Ighebda Ertsa Da Imave Sagans Orjer
            //Es Ukanaskneli Ki Amocanis Mixedvit Iqneboda Shecdoma.
            //Amitomac Gavakete Ase!!!!!!!!!!!
            for (int i = 0; i < 50; i++)
            {
                modelbuilder.Entity<StudentSubject>().HasData(
                      new StudentSubject() { StudentSubjectId = z, StudentId = Stud[i].StudentId, SubjectId = Subj[rnd.Next(0, Subj.Count() - 2)].SubjectId } //50 Studenti
                      );
                z++;
                modelbuilder.Entity<StudentSubject>().HasData(
                      new StudentSubject() { StudentSubjectId = z, StudentId = Stud[i].StudentId, SubjectId = Subj[rnd.Next(3, Subj.Count())].SubjectId } //50 Studenti
                      );
                z++;
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<StudentSubject> Subjects { get; set; }
    }

    public class StudentSubject
    {
        public int StudentSubjectId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int Grade { get; set; }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public List<StudentSubject> Students { get; set; }
    }
}
