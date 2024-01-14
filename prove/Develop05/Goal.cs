using System;

class Goal {
    private string name;
    private GoalType type;
    private int value;
    private int count;
    private int targetCount;
    private int bonusPoints;
    private bool completed;

    public Goal(string name, GoalType type, int value, int count, int targetCount, int bonusPoints) {
        this.name = name;
        this.type = type;
        this.value = value;
        this.count = count;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.completed = false;
    }
    