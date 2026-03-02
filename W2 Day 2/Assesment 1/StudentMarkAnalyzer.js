// Store student marks
const marks = [70, 90, 60, 50, 80];
const calculateTotal = (arr) =>
    arr.reduce((sum, mark) => sum + mark, 0);
const calculateAverage = (arr) =>
    calculateTotal(arr) / arr.length;
const getResult = (avg) =>
    avg >= 50 ? "Pass" : "Fail";

const convertToGrades = (arr) =>
    arr.map(mark =>
        mark >= 90 ? "A+" :
        mark >= 75 ? "A" :
        mark >= 60 ? "B" :
        mark >= 50 ? "C" : "F"
    );

const total = calculateTotal(marks);
const average = calculateAverage(marks);
const result = getResult(average);
const grades = convertToGrades(marks);

document.getElementById("output").innerHTML = `
    <p><strong>Marks:</strong> ${marks.join(", ")}</p>
    <p><strong>Total:</strong> ${total}</p>
    <p><strong>Average:</strong> ${average.toFixed(2)}</p>
    <p><strong>Result:</strong> ${result}</p>
    <p><strong>Grades:</strong> ${grades.join(", ")}</p>
`;