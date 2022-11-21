using System.Diagnostics;
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
		var timer = new Stopwatch();
		timer.Start();
		
		Initialize();
		
		timer.Stop();
		Console.WriteLine("Time taken: " + timer.Elapsed.ToString(@"m\:ss\.fff")); 

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
		//TBD
	}
	protected virtual void Draw()
	{
		Raylib.ClearBackground(Color.WHITE);
	}
	#endregion
}