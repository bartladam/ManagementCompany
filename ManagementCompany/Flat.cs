using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCompany
{
    /// <summary>
    /// Flat is management by management company
    /// </summary>
    internal class Flat
    {
        /// <summary>
        /// Flat has address for worker. Worker need know where flat is.
        /// </summary>
        public string Adress { get; private set; }
        /// <summary>
        /// Flat in during his lifetime is need some repair
        /// </summary>
        public List<string> problems { get; set; }
        public Flat(string adress)
        {
            this.Adress = adress;
        }
        /// <summary>
        /// Owner can add new problems
        /// </summary>
        /// <param name="problems"></param>
        public void newProblem(params string[] problems)
        {
            this.problems = new List<string>(problems);
        }
    }
}
