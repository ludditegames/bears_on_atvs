using Godot;
using System;

public class Slot {
    public const int SINGLETON_GLOBALS_ID = 312; // do not change me
    public int Id { get{ return SINGLETON_GLOBALS_ID; } set{}}
    public int NumLives { get; set; }
    public int NumContinuesUsed { get; set;}
    public int HighestLevelNumUnlocked { get; set;}
    public int currentLevelNumHoveringOver { get; set;}
    public static Slot Default { get {
        return new Slot(){
            NumLives = Player.DEFAULT_NUM_LIVES,
            NumContinuesUsed = 0,
            HighestLevelNumUnlocked = 1,
            currentLevelNumHoveringOver = 0,
        };}}}

public class SlotSnapshot{
    public Slot Slot;
    public LevelStatsRecord[] LevelStatsRecords; 
}
