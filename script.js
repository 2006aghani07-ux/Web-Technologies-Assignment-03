const api = "https://localhost:7000/api/students";

async function load() {
const res = await fetch(api);
const data = await res.json();

let rows = "";

data.forEach(s => {
rows += `
<tr>
<td>${s.name}</td>
<td>${s.email}</td>
<td>${s.department}</td>
<td>
<button onclick="del('${s.id}')">Delete</button>
</td>
</tr>`;
});

document.getElementById("table").innerHTML = rows;
}

async function del(id) {
await fetch(`${api}/${id}`, { method: "DELETE" });
load();
}

const form = document.getElementById("form");

if (form) {
form.addEventListener("submit", async (e) => {
e.preventDefault();

const student = {
name: name.value,
email: email.value,
department: department.value
};

await fetch(api, {
method: "POST",
headers: { "Content-Type": "application/json" },
body: JSON.stringify(student)
});

window.location.href = "index.html";
});
}
load();
