using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCompany
{
    /// <summary>
    /// Management company save contacts on workers
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// If we need worker often, thats contact could be favorite.
        /// </summary>
        private bool favorite { get; set; }
        public Contact(string name, string surname, uint telephone, Profession profesion, bool favorite) : base(name, surname, telephone, profesion)
        {
            this.favorite = favorite;
        }

        /// <summary>
        /// Via mobile phone we call worker to repair something
        /// </summary>
        /// <param name="flat"></param>
        /// <param name="issue"></param>
        /// <returns></returns>
        public string CallWorkerToWork(Flat flat, string issue) => Repair(flat, issue);
    }
}
