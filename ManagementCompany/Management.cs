using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCompany
{
    /// <summary>
    /// Management company solve problems owners
    /// </summary>
    internal class Management
    {
        /// <summary>
        /// Management company manage a lot of flats. Not only one flat
        /// </summary>
        public List<Flat> flats { get; private set; }
        /// <summary>
        /// Management company have to contacts on workers 
        /// </summary>
        public List<Contact> contacts { get; private set; }
        public Management(params Flat[] flats)
        {
            this.flats = new List<Flat>(flats);
            contacts = new List<Contact>();
        }
        /// <summary>
        /// Adding new contact on workers
        /// </summary>
        /// <param name="contact"></param>
        public void newContact(Contact contact)
        {
            contacts.Add(contact);
        }
        /// <summary>
        /// Company is solving problems owner flats
        /// </summary>
        /// <returns></returns>
        public string Solution()
        {
            string solveIssue = "";
            foreach (Flat item in flats)
            {
                List<string> issues = new List<string>(item.problems);
                foreach (string item2 in issues)
                {
                    foreach (Contact contactWorker in contacts)
                    {
                        if (item2.Equals(contactWorker.profesion.ToString()))
                            solveIssue += contactWorker.CallWorkerToWork(item, item2) + "\n";

                    }
                }

            }
            return solveIssue;
        }
    }
}
