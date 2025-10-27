# PlayerPrefs_Unity

# PlayerPrefs Data Manager

A Unity project demonstrating persistent data storage using PlayerPrefs.

## How It Works

### Data Storage
The script saves three types of data:
- **Player Name** (string) - Stored with key `"PlayerName"`
- **Score** (int) - Stored with key `"Score"`
- **Playtime** (float) - Stored with key `"Playtime"`

### Core Methods

**SaveData()**
```csharp
PlayerPrefs.SetString("PlayerName", playerName);
PlayerPrefs.SetInt("Score", score);
PlayerPrefs.SetFloat("Playtime", playtime);
PlayerPrefs.Save();  // Writes to disk
```

**LoadData()**
```csharp
playerName = PlayerPrefs.GetString("PlayerName", "Player");  // Default: "Player"
score = PlayerPrefs.GetInt("Score", 0);                      // Default: 0
playtime = PlayerPrefs.GetFloat("Playtime", 0f);             // Default: 0f
```

**Auto-Save System**
- Playtime increments every second using `InvokeRepeating()`
- Data automatically saves when application quits via `OnApplicationQuit()`

## Testing the Features

### Setup
1. Attach `PlayerPrefsDataManager.cs` to a GameObject
2. Assign UI components in Inspector (DisplayText, NameInput)
3. Link buttons to their methods (Save, Load, AddScore, Reset)

### Test Sequence

**Test 1: Save & Load**
1. Enter a name in the input field
2. Click "Save"
3. Close Unity and reopen
4. Click "Load" - name should reappear

**Test 2: Score Tracking**
1. Click "Add Score" multiple times
2. Watch the score increase by 10 each time
3. Restart the scene - click "Load" to retrieve score

**Test 3: Playtime**
1. Run the game and wait
2. Observe playtime incrementing every second
3. Close and reopen - playtime persists

**Test 4: Reset**
1. Click "Reset"
2. All data clears to defaults (Player, 0, 0f)
3. Restart to confirm data was deleted from disk
