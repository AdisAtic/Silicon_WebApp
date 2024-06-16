document.addEventListener('DOMContentLoaded', function () {
    handleProfileImageUpload(); // Ensure the function is called
});

function handleProfileImageUpload() {
    try {
        let fileUploader = document.querySelector('#fileUploader');
        if (fileUploader != undefined) {
            fileUploader.addEventListener('change', function () {
                if (this.files.length > 0) {
                    this.form.submit();
                }
            });
        }
    } catch (error) {
        console.error("An error occurred while uploading the profile image:", error);
    }
}