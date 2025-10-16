using System;


abstract class Goal {

  #_name: string

  #_summary: string

  #_points: int

  

  +Goal(name: string, summary: string, points: int)

  +abstract int RecordEvent()

  +abstract bool IsComplete()

  +abstract string GetDisplayString()