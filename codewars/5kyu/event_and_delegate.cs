using System.Collections.Generic;
using System;

public class PersonEventArgs : EventArgs
{
    public string Name { get; set; }
}

public class Publisher
{
    public event EventHandler<PersonEventArgs> ContactNotify;

    public void CountMessages(List<string> peopleList)
    {
        var map = new Dictionary<string, int>();
        foreach (string person in peopleList)
        {
            var isInMap = map.TryGetValue(person, out _);
            if (isInMap) 
            {
              map[person]++;
              if (map[person] % 3 == 0) 
              {
                OnContactNotify(person);
              }
            }
            else
            {
              map.Add(person, 1);
            }
        }
    }
  
    public void OnContactNotify(string person)
    {
        ContactNotify?.Invoke(this, new PersonEventArgs { Name  = person });
    }
}
