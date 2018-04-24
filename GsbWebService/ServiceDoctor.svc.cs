using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GsbWebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceDoctor" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceDoctor.svc ou ServiceDoctor.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceDoctor : IServiceDoctor
    {
        DoctorRepository doctorRepository = new DoctorRepository();

        public IList<DoctorEntity> ConsultAllDoctors()
        {
            return doctorRepository.SelectAll();
        }

        public IList<DoctorEntity> ConsultDoctorsByDepartment(int department)
        {
            return doctorRepository.SelectByDepartment(department);
        }

        public IList<DoctorEntity> ConsultDoctorsByLastname(String lastname)
        {
            return doctorRepository.SelectByLastname(lastname);
        }
    }
}
