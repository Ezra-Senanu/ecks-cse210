using System;

class Goal {
    public string name;
    public GoalType type;
    public int value;
    public int count;
    public int targetCount;
    public int bonusPoints;
    public bool completed;

    public Goal(string name, GoalType type, int value, int count, int targetCount, int bonusPoints) {
        this.name = name;
        this.type = type;
        this.value = value;
        this.count = count;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.completed = false;
    }
    