namespace FlexiSkills.Utilities
{
    public interface IPaymentService
    {
        Task<String> GenerateRRR(
            String amount, String name, String phoneNo, String email,
            String paymentName, String matno, String paymentid, String Sessionname);
    }
}
