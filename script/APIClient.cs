using Godot;
using System;
using System.Net.Http;

public partial class APIClient : Node2D
{
	// private static readonly HttpClient client = new HttpClient();
	private static readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

	public override void _Ready()
	{
		GetWordsFromApi(1);

	}

	public async void GetWordsFromApi(int seasonId)
	{
		string apiUrl = $"http://localhost:5000/words/seasons/{seasonId}";



		try
		{
			HttpResponseMessage response = await client.GetAsync(apiUrl);
			response.EnsureSuccessStatusCode();

			string responseData = await response.Content.ReadAsStringAsync();
			GD.Print("API Response: " + responseData);
		}
		catch (Exception e)
		{
			GD.PrintErr($"Fout bij ophalen data: {e.Message}");
		}


	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
