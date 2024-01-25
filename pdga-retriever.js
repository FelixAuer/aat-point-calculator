const title = document.querySelector('h1').textContent;

const detailsElements = document.querySelectorAll('details');

let output = `{
    "name": "${title}", 
    "divisions": [`

// Iterate through each details element
detailsElements.forEach((detailsElement, bracketIndex) => {
    // Extract and output the bracket name
    const bracketNameElement = detailsElement.querySelector('h3.division');
    const bracketName = bracketNameElement ? bracketNameElement.id : `Bracket ${bracketIndex + 1}`;

    // Select all tr elements inside the current details element
    const trElements = detailsElement.querySelectorAll('tr');
    output += `{
    "name": "${bracketName}", 
    "results": [`
    // Iterate through each tr element and output its content
    trElements.forEach((trElement, trIndex) => {
        // Select specific td elements within the current tr element
        const placeTd = trElement.querySelector('td.place');
        const playerTd = trElement.querySelector('td.player');
        const pdgaNumberTd = trElement.querySelector('td.pdga-number');
        const totalTd = trElement.querySelector('td.total');

        if (placeTd) {
            output += `{
            "name": "${playerTd?.textContent.trim()}",
            "pdga-number": "${pdgaNumberTd?.textContent.trim()}",
            "place": "${placeTd?.textContent.trim()}",
            "total": "${totalTd?.textContent.trim()}"
        },`
        }
    });
    output = output.slice(0, -1)
    output += "]},"
});
output = output.slice(0, -1)
output += "]}"

console.log(output)