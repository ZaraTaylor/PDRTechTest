using PDR.PatientBooking.Service.BookingServices.Requests;
using PDR.PatientBooking.Service.Validation;

namespace PDR.PatientBooking.Service.BookingServices.Validation
{
    public interface IGetPatientNextAppointmentValidator
    {
        PdrValidationResult ValidateRequest(GetPatientNextAppointmentRequest request);
    }
}