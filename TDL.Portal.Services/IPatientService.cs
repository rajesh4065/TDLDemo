using System.Threading.Tasks;
using TDL.Common;

namespace TDL.Portal.Services
{
    public interface IPatientService
    {
        Task<PatientDetailsDto> GetPatientDetails();

        Task<PatientOutPutDto> UpdatePatientDetails(PatientSubmitDto patientInputDto);
    }
}
