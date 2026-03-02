// Hardcoded users for frontend testing
const users = {
    admin: "admin123",
    user1: "pass1",
    user2: "pass2"
};

// Login logic
document.getElementById("loginForm").addEventListener("submit", function (e) {
    e.preventDefault();
    const username = document.getElementById("username").value.trim();
    const password = document.getElementById("password").value.trim();
    const message = document.getElementById("loginMessage");

    if (!username || !password) {
        message.textContent = "Username and password cannot be empty!";
        message.style.color = "red";
        return;
    }

    if (users[username] && users[username] === password) {
        message.textContent = "Login successful!";
        message.style.color = "green";
    } else {
        message.textContent = "Invalid username or password!";
        message.style.color = "red";
    }
});

// Grade logic
document.getElementById("gradeForm").addEventListener("submit", function (e) {
    e.preventDefault();
    const marks = parseInt(document.getElementById("marks").value);
    const message = document.getElementById("gradeMessage");
    let grade = "";

    if (marks >= 80) grade = "A";
    else if (marks >= 60) grade = "B";
    else if (marks >= 40) grade = "C";
    else grade = "F";

    message.textContent = `Grade: ${grade}`;
    message.style.color = "#007bff";
});
