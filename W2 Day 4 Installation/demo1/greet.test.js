const greet = require("./greet");

test("callback should be called", () => {
  const mockFn = jest.fn();//fake function or mock function

  greet(mockFn);//calling the grret function

  expect(mockFn).toHaveBeenCalled();
  expect(mockFn).toHaveBeenCalledWith("same");//to check the argument passed to the mock function
});