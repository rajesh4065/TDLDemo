using System.Threading.Tasks;
using TDL.Common;

namespace TDL.Services
{
    public interface IPatientService
    {
        Task<PatientDetailsDto> GetPatientDetails();

        Task<PatientOutPutDto> UpdatePatientDetails(PatientInputDto patientInputDto);
    }
}
