using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _classes=new List<SchoolClass>();

        public SchoolClassRepo(List<SchoolClass> classes)
        {
            _classes = classes;
        }
        public List<SchoolClass> FindAll() =>_classes;

        public string MostPayedClass()
        {
            if (!FindAll().Any())
            {
                return string.Empty;
            }
            else
            {
                int maxPay = FindAll().Select(classe => classe.haviPenz).Max();
                SchoolClass? classe = FindAll().Where(classe => classe.haviPenz == maxPay).FirstOrDefault();
                return classe is null ? string.Empty : classe.evfolyam + classe.osztaly;
            }
        }

    }
}
