# Ghost Hunt Missions Specification

Ghost Hunt Squad is the flagship mode of CrazeVerse India Battle World.

## Core Flow

1. Enter a fictional India-inspired mystery map.
2. Search for clues.
3. Collect sacred items.
4. Handle rival squad pressure.
5. Survive ghost events.
6. Complete ritual objective.
7. Face boss ghost event.
8. Open escape gate.
9. Escape before timer ends.

## Squad Roles

- Hunter: combat role.
- Mystic: detection and ritual support.
- Medic: healing and revive support.
- Scout: clue detection and trap finding.

## Mission Types

- Clue Hunt
- Ritual Run
- Escape Chase
- Rescue Mission
- Boss Ghost Fight
- Cursed Object Destroy
- Stealth Night
- Timed Survival
- Puzzle Lock
- Lamp Lighting
- Spirit Escort
- Haunted Vehicle Repair
- Cursed Idol Collection
- Blackout Survival
- Ghost Energy Capture
- Final Ritual Escape

## Mission Data Fields

Each mission must include missionId, missionName, mapName, playerMode, difficulty, objective, winCondition, rewardXP, rewardCoins, bossType, timeLimit, recommendedRoles, and specialEvent.

## 126+ Mission Rule

Create 126 or more missions in JSON or ScriptableObject format during the mission database step. For now this file documents the required structure only.