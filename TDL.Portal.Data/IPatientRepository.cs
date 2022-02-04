using System.Threading.Tasks;
using TDL.Common;

namespace TDL.Portal.Data
{

    public interface IPatientRepository
    {
        Task<PatientDetailsDto> GetPatientDetails();
        Task<PatientOutPutDto> UpdatePatientDetails(PatientInputDto patientInputDto);
    }
}


