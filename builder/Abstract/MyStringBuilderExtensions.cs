public static class MyStringBuilderExtensions
{
    // Putem folosi primitive in metodele de extensie si sa implementam metode pentru necesitati specifice cu denumiri sugestive
    public static MyStringBuilder AddNewLine(this MyStringBuilder builder)
    {
        return builder.Add("\r\n");
    }
}