# Technical Architecture

## Engine

- Unity 3D URP
- C#
- Android mobile first
- Local prototype first
- Backend-ready interfaces
- Low-end Android optimisation from day one
- Data-driven game systems

## Architecture Rule

The first prototype must work fully offline/local with mock services. Future online services must plug into interfaces without rewriting gameplay.

## Local Service Interfaces

- IAuthService
- IProfileService
- IMatchmakingService
- ILeaderboardService
- IInventoryService
- IEconomyService
- IFriendsService
- IClanService
- ICloudSaveService
- IShopService
- IEventService
- IAnalyticsService
- IAIContentService

## Local Services

- LocalAuthService
- LocalProfileService
- LocalMatchmakingService
- LocalLeaderboardService
- LocalInventoryService
- LocalEconomyService
- LocalFriendsService
- LocalClanService
- LocalCloudSaveService
- LocalShopService
- LocalEventService
- LocalAnalyticsService
- LocalAIContentService

## Core Managers

GameManager, SceneLoader, SaveManager, PlayerProfileManager, EconomyManager, MissionManager, MatchManager, MatchmakingManager, BotManager, SquadManager, UIManager, AudioManager, SettingsManager, LocalisationManager, RewardManager, InventoryManager, ReportManager, DownloadManager, EventManager, AIContentManager.