using System.Numerics;
using Raylib_cs;

namespace Pine2D.Core;

public class PineApp
{
	private readonly WindowSettings _windowSettings;
	
	protected PineApp(WindowSettings windowSettings)
	{
		_windowSettings = windowSettings;
	}
	
	public void Run()
	{
		// Initialization
		Initialize();
		
		while (!Raylib.WindowShouldClose())
		{
			// Update
			Update();
			// ------

			// Draw
			Raylib.BeginDrawing(); 
			Draw();
			Raylib.EndDrawing();
			// ----
		}
        
		// De-Initialization
		Raylib.CloseWindow();
	}
	
	#region Events
	
	protected virtual void Initialize()
	{
		Raylib.InitWindow(_windowSettings.ScreenWidth, _windowSettings.ScreenHeight, _windowSettings.Title);
		Console.WriteLine("Initialized Pine2D Engine!");
	}
	protected virtual void Update()
	{
		
	}
	protected virtual void Draw()
	{
		Raylib.ClearBackground(Color.WHITE);
		Raylib.DrawText(Raylib.GetFPS().ToString(), 16, 16, 20, Color.BLACK);
	}

	#endregion
}