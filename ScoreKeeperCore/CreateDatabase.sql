USE [wildcats]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 9/5/2023 11:11:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[GameId] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NULL,
	[Location] [varchar](255) NULL,
	[FinalScore] [varchar](255) NULL,
	[GameDateTime] [datetime] NULL,
	[HomeGame] [bit] NULL,
	[Outcome] [varchar](255) NULL,
	[OpposingTeamNameOrId] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[GameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerGameStat]    Script Date: 9/5/2023 11:11:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerGameStat](
	[PlayerGameStatId] [int] IDENTITY(1,1) NOT NULL,
	[GameId] [int] NULL,
	[TeamPlayerId] [int] NULL,
	[Goals] [int] NULL,
	[Assists] [int] NULL,
	[Shots] [int] NULL,
	[Saves] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PlayerGameStatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamPlayers]    Script Date: 9/5/2023 11:11:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamPlayers](
	[TeamPlayerId] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NULL,
	[Name] [varchar](255) NULL,
	[Number] [int] NULL,
	[Position] [varchar](255) NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TeamPlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 9/5/2023 11:11:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[TeamId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([TeamId])
GO
ALTER TABLE [dbo].[PlayerGameStat]  WITH CHECK ADD FOREIGN KEY([GameId])
REFERENCES [dbo].[Games] ([GameId])
GO
ALTER TABLE [dbo].[PlayerGameStat]  WITH CHECK ADD FOREIGN KEY([TeamPlayerId])
REFERENCES [dbo].[TeamPlayers] ([TeamPlayerId])
GO
ALTER TABLE [dbo].[TeamPlayers]  WITH CHECK ADD FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([TeamId])
GO
