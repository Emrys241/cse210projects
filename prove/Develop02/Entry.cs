class Entry 
{
    string prompt, date, time, response;
    
    public Entry(string _time,string _date, string _prompt, string _response)
    {
        
        prompt =  _prompt;
        date = _date;
        response = _response;
        time = _time;
    }
    public void DisplayEntry()
    {
    Console.WriteLine("Time: {0}", prompt);
    Console.WriteLine("Date: {0}", date);
    Console.WriteLine("Prompt: {0}", time);
    Console.WriteLine("Response: {0}", response);
    }
    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}|{3}", prompt, date, time, response);
    }
}