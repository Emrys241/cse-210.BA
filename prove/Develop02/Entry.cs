class Entry 
{
    string date, prompt, response;
    
    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt =  _prompt;
        response = _response;
    }
    public void DisplayEntry()
    {
    Console.WriteLine("Date: {0}", date);
    Console.WriteLine("Prompt: {0}", prompt);
    Console.WriteLine("Response: {0}", response);
    }
    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }
}