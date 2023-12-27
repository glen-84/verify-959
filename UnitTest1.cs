namespace verify_959;

[UsesVerify]
public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        await VerifyJson("""
            {
                "date": "2023-12-27T12:52:28.657Z"
            }
            """);
    }
}
