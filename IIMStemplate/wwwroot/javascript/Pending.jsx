class Pending extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="Pending">I am a Pending user landing page for users who do not have permissions yet.
            </div>
            // Also needs to handle authorization redirect for unauthorized user.
            // Render a link to documentation for application and "Pending user waiting for approval seek admin"
        );
    }
}

export Pending;