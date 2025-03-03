const pwdBtn = document.querySelector(`.show-password`);
const pwdInput = document.querySelector(`#password`);

pwdBtn.addEventListener(`click`, (e) => {
  e.preventDefault();
  togglePwdVisible();
});

const togglePwdVisible = () => {
  if (pwdInput.type === "password") {
    pwdInput.type = "text";
    pwdBtn.classList.remove("fa-eye");
    pwdBtn.classList.add("fa-eye-slash");
  } else {
    pwdInput.type = "password";
    pwdBtn.classList.remove("fa-eye-slash");
    pwdBtn.classList.add("fa-eye");
  }
};
