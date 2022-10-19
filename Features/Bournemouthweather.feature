Feature: Bournemouthweather

You will need to search for Bournemouth so you can see the weather results for Bournemouth.

@WeatherResults
Scenario: search for Bournemouth weather results
	Given I navigate to weather page on the BBC website 
	When I search for 'Bournemouth' weather results
	Then I should be taken to 'Bournemouth' BBC weather page
