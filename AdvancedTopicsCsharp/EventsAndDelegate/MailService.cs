public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
        Console.WriteLine("MailSerice: Sending an email..." + args.Video.Title);
    }
}