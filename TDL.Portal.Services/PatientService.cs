using System.Threading.Tasks;
using TDL.Common;
using TDL.Portal.Data;

namespace TDL.Portal.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _iPatientRepository;
        public PatientService(IPatientRepository studentRepository)
        {
            _iPatientRepository = studentRepository;
        }
        public async Task<PatientDetailsDto> GetPatientDetails()
        {

            var data = await _iPatientRepository.GetPatientDetails();
            data.PatientSubmitDto.RecordId = data.RecordId;
            return data;
        }

        public async Task<PatientOutPutDto> UpdatePatientDetails(PatientSubmitDto patientInputDto)
        {
            var patient = new PatientInputDto
            {
                AuthorisedBy = patientInputDto.AuthorisedBy,
                Conclusion = patientInputDto.Conclusion,
                RecordId = patientInputDto.RecordId
            };
            return await _iPatientRepository.UpdatePatientDetails(patient);
        }
    }
}
