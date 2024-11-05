

using MedicalAppointment.HistoriasClinicas.Domain;
using MedicalAppointment.Shared.Presentation;

namespace MedicalAppointment.HistoriasClinicas.CreateHistoriaClinica
{
    internal class CreateHistoriaClinicaResponse : IApplicationResponse
    {
        private readonly HistoriaClinica _historiaClinica;
        public CreateHistoriaClinicaResponse(HistoriaClinica historiaClinica) => _historiaClinica = historiaClinica;
        public override string ToString()
        {
            return $"Historia Clinica número: {_historiaClinica.Id}\n" +
                   $"Paciente Id: {_historiaClinica.PacienteId}\n" +
                   $"Doctor Id: {_historiaClinica.DoctorId}";
        }

    }
}
