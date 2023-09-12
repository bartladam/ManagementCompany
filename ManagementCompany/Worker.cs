using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCompany
{
    /// <summary>
    /// Management company need workers for repair problems in flat
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Worker has name. When we call worker we need his name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        ///  Worker has surname. When we call worker we need his name
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// We need worker telephone number for call him on some work
        /// </summary>
        public uint telephoneNumber { get; private set; }
        /// <summary>
        /// Each worker has some specialization
        /// </summary>
        public enum Profession { locksmith, plumber, gardener, tinman, bricklayer };
        public Profession profesion;
        public Worker(string name, string surname, uint telephone, Profession profesion)
        {
            this.Name = name;
            this.Surname = surname;
            this.telephoneNumber = telephone;
            this.profesion = profesion;
        }
        /// <summary>
        /// We call worker and we need by him some work 
        /// </summary>
        /// <param name="Flat"></param>
        /// <param name="issue"></param>
        /// <returns></returns>
        public string Repair(Flat Flat, string issue)
        {
            Flat.problems.Remove(issue);

            return string.Format("Flat adress: {0}\nWorker name: {1}\nWorker surname: {2}\nIssue: solved\n", Flat.Adress, Name, Surname);
        }
    }
}
