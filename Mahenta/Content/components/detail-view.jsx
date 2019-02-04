

export const DetailView = (props) => {

    const showHideClassName = props.show ? "modal show-modal" : 'modal hide-modal';

    return (
        <div className={showHideClassName}>
            <div className="modal-main">
                <button onClick={props.handleClose}>X</button>
                {props.children}
            </div>
        </div>
    )
}