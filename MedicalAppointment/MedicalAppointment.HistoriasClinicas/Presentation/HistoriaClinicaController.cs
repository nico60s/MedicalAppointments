

using MedicalAppointment.HistoriasClinicas.CreateHistoriaClinica;
using MedicalAppointment.HistoriasClinicas.Infrastructure.Commands;
using MedicalAppointment.Shared.Presentation;
using System.Net;

namespace MedicalAppointment.HistoriasClinicas.Presentation
{
    public class HistoriaClinicaController : EndPoint
    {
        public HistoriaClinicaController(CommandBus<IApplicationResponse> commandbus) 
        { 
            
        }
        public void CreateHistoriaClinica(Guid doctorId, Guid pacienteId)
        {
            //Crear comando con el request del cliente
            CreateHistoriaClinicaCommand createHistoriaClinicaCommand = new();
            createHistoriaClinicaCommand.DoctorId = doctorId;
            createHistoriaClinicaCommand.PacienteId = pacienteId;

            //Crear Handler para manejar request para el command --puede utilizarse mediatR
            CreateHistoriaClinicaCommandHandler createHistoriaClinicaCommandHandler = new();
            createHistoriaClinicaCommandHandler.Handle(createHistoriaClinicaCommand, CancellationToken.None);

        }
    }
}
