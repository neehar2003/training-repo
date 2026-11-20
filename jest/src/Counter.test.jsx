import { render, screen, fireEvent } from "@testing-library/react";
import Counter from "./Counter";

// Test 1: the button is on the page
test("shows the Increment button", () => {
  render(<Counter />);
  expect(screen.getByText("Increment")).toBeInTheDocument();
});

// Test 2: it starts at 0
test("starts at 0", () => {
  render(<Counter />);
  expect(screen.getByText("Count: 0")).toBeInTheDocument();
});

// Test 3: clicking adds 1
test("goes up after clicking", () => {
  render(<Counter />);
  fireEvent.click(screen.getByText("Increment"));
  expect(screen.getByText("Count: 1")).toBeInTheDocument();
});
