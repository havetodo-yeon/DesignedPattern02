using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface PSubject
{
    void Register(PObserver observer);
    void Remove(PObserver observer);
    void Notify();
}
