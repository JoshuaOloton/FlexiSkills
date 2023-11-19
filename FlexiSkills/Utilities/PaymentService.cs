namespace FlexiSkills.Utilities
{
    public class PaymentService : IPaymentService
    {
        RRRServiceReference.WebService1SoapClient client = new(RRRServiceReference.WebService1SoapClient.EndpointConfiguration.WebService1Soap);
        public async Task<string> GenerateRRR(string amount, string name, string phoneNo, string email, string paymentName, string matno, string paymentid, string Sessionname)
        {
            String? remita = (await client.geninvAsyncAsync(
                amount: amount,
                name: name,
                phone: phoneNo,
                email: email,
                description: $"{paymentName} PAYMENT FOR {name}",
                matno: matno,
                paymentid: paymentid,
                session: Sessionname,
                user: "joshresult",
                token: "236y7e@4783"
                )).Body.geninvAsyncResult;


            return remita;
        }
    }
}
