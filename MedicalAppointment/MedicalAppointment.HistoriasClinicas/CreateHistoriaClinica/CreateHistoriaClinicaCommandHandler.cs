using MedicalAppointment.HistoriasClinicas.Domain;
using MedicalAppointment.Shared.Application.Contracts;

namespace MedicalAppointment.HistoriasClinicas.CreateHistoriaClinica
{
    internal class CreateHistoriaClinicaCommandHandler : ICommandHandler<CreateHistoriaClinicaCommand>
    {
        public CreateHistoriaClinicaCommandHandler() { }

        public Task Handle(CreateHistoriaClinicaCommand request, CancellationToken cancellationToken)
        {
            HistoriaClinica.Create(HistoriaClinicaId.Create(), request.PacienteId, request.DoctorId);
            return Task.CompletedTask;
            
        }
    }
}
