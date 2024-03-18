// Function to submit leave request
// Function to submit the form data to the API endpoint
async function submitLeaveRequest() {
    try {
        // Fetch form data
        const formData = new FormData(document.getElementById('LeaveReqForm'));
        // Make POST request to API endpoint
        const response = await fetch('/api/LeaveRequests', {
            method: 'POST',
            body: formData
        });
        // Check if request was successful
        if (response.ok) {
            // Redirect to confirmation page or handle success scenario
            window.location.href = '/ConfirmationLeaveRequestPage';
        } else {
            // Handle error scenario
            console.error('Failed to submit leave request');
            alert('Failed to submit leave request');
        }
    } catch (error) {
        console.error('An error occurred:', error);
        alert('An error occurred while submitting leave request');
    }
}

// Attach click event listener to the submit button
document.getElementById('submitLeaveRequestButton').addEventListener('click', submitLeaveRequest);